using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Aerotech.A3200;
using Aerotech.A3200.Exceptions;
using Aerotech.A3200.Status;
using Aerotech.A3200.Variables;
using Aerotech.A3200.Tasks;
using Aerotech.A3200.Information;
using Aerotech.Common;
using Aerotech.Common.Collections;

using Basler.Pylon;
using System.Diagnostics;
using System.Drawing.Imaging;
using Emgu.CV.Structure;
using Emgu.CV;

namespace pozycjonowanie1
{
    public partial class Form1 : Form
    {
        private Controller myController;
        private Camera camera = null;
        private PixelDataConverter converter = new PixelDataConverter();
        private Stopwatch stopWatch = new Stopwatch();
        public int pozx;
        public int pozy;
        public int wart=10;
        private int wyjscie;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Controller.Disconnect();
            DestroyCamera();
        }

        private void bt_Pozycjonuj_Click(object sender, EventArgs e)
        {
            Pozycjonuj();
        }

        private void SetAxisState(NewDiagPacketArrivedEventArgs e)
        {
            lbl_PozycjaX.Text=e.Data["X"].PositionFeedback.ToString();
            lbl_PozycjaY.Text=e.Data["Y"].PositionFeedback.ToString();
            lbl_speedx.Text = e.Data["X"].VelocityFeedback.ToString();
            lbl_speedy.Text = e.Data["Y"].VelocityFeedback.ToString(); 
        }

        private void Pozycjonuj()
        {
            try
            {
                myController = Controller.Connect();
                myController.ControlCenter.Diagnostics.NewDiagPacketArrived += new EventHandler<NewDiagPacketArrivedEventArgs>(NewDiagPacketArrived);
                Connect();
                this.myController.Commands[TaskId.T01].Axes["X"].Motion.Enable();
                this.myController.Commands[TaskId.T01].Axes["Y"].Motion.Enable();
                this.myController.Commands[TaskId.T01].Axes["Z"].Motion.Enable();
                this.myController.Commands[TaskId.T01].Axes["X"].Motion.Home();
                this.myController.Commands[TaskId.T01].Axes["Y"].Motion.Home(); 
                this.myController.Commands[TaskId.T01].Axes["Z"].Motion.Home();
                this.myController.Commands.Motion.Linear("X", -38, 15);
                this.myController.Commands.Motion.Linear("Y", -38, 15);
                for (int pozy = 0; pozy < 9; pozy++)
                {
                    for (int pozx = 0; pozx < 8; pozx++)
                    {
                        this.myController.Commands.Motion.Linear("X", wart, 15);
                        if (pozy == 4 && pozx == 3)
                        {
                            OneShot();
                            TemplateMatching();
                            if (wyjscie == 1)
                            {
                                break;
                            }
                        }
                    }
                    if(pozy == 8 || wyjscie == 1)
                    {
                        break;
                    }
                    else
                    {
                        this.myController.Commands.Motion.Linear("Y", 10, 15);
                        wart = -1 * wart;
                    }
                    
                }
            }
            catch (A3200Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void NewDiagPacketArrived(object sender, NewDiagPacketArrivedEventArgs e)
        {
            try
            {
                this.Invoke(new Action<NewDiagPacketArrivedEventArgs>(SetAxisState), e);
            }
            catch
            {

            }
        }
        private void OneShot()
        {
            try
            {
                Configuration.AcquireSingleFrame(camera, null);
                camera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void DestroyCamera()
        {
            try
            {
                if (camera != null)
                {
                    camera.Close();
                    camera.Dispose();
                    camera = null;
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void Connect()
        {
            try
            {
                camera = new Camera();
                camera.CameraOpened += Configuration.AcquireContinuous;

                camera.ConnectionLost += OnConnectionLost;
                camera.CameraOpened += OnCameraOpened;
                camera.StreamGrabber.GrabStarted += OnGrabStarted;
                camera.StreamGrabber.ImageGrabbed += OnImageGrabbed;
                camera.StreamGrabber.GrabStopped += OnGrabStopped;

                camera.Open();
                camera.Parameters[PLCamera.Width].SetValue(1500);
                camera.Parameters[PLCamera.Height].SetValue(1500);
                camera.Parameters[PLCamera.CenterX].SetValue(true);
                camera.Parameters[PLCamera.CenterY].SetValue(true);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void OnGrabStopped(object sender, GrabStopEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<GrabStopEventArgs>(OnGrabStopped), sender, e);
                return;
            }

            //resetujemy stopwacht
            stopWatch.Reset();

            //Jezeli kamera przestała łapac obrazy wyswietlamy bląd
            if (e.Reason != GrabStopReason.UserRequest)
            {
                MessageBox.Show("A grab error occured:\n" + e.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnImageGrabbed(object sender, ImageGrabbedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<ImageGrabbedEventArgs>(OnImageGrabbed), sender, e.Clone());
                return;
            }
            try
            {
                IGrabResult grabResult = e.GrabResult;
                if(grabResult.IsValid) 
                {
                    if(!stopWatch.IsRunning || stopWatch.ElapsedMilliseconds > 33)
                    {
                        stopWatch.Restart();

                        Bitmap bitmap = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
                        BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                        converter.OutputPixelFormat = PixelType.BGRA8packed;
                        IntPtr ptrBmp = bmpData.Scan0;
                        converter.Convert(ptrBmp, bmpData.Stride * bitmap.Height, grabResult);
                        bitmap.UnlockBits(bmpData);
                        Bitmap bitmapOld = pictureBox1.Image as Bitmap;
                        pictureBox1.Image = bitmap;
                        if(bitmapOld != null)
                        {
                            bitmapOld.Dispose();
                        }
                    }
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            finally
            {
                e.DisposeGrabResultIfClone();
            }
        }

        private void OnGrabStarted(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OnGrabStarted), sender, e);
                return;
            }
        }
        private void OnCameraClosed(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OnCameraClosed), sender, e);
                return;
            }
        }
        private void OnCameraOpened(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OnCameraOpened), sender, e);
                return;
            }
        }
        private void OnConnectionLost(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                //Używamy metody invoke by odwołać się do odpowiedniego elementu
                BeginInvoke(new EventHandler<EventArgs>(OnConnectionLost), sender, e);
                return;
            }
            //Zamykamy kamere
            DestroyCamera();
        }
        private void TemplateMatching()
        {
            try
            {
                if(pictureBox1.Image == null)
                {
                    return;
                }
                try
                {
                    Bitmap srcBitmap = new Bitmap(pictureBox1.Image);
                    Image<Gray, byte> imgSrc = srcBitmap.ToImage<Gray, byte>();
                    //"kostkatest2.png"
                    //"monotestKostka.jpg"
                    string template = "kostkatest2.png";
                    Mat MatTemplate = CvInvoke.Imread(template);
                    Image<Gray, byte> imgTemplate = MatTemplate.Clone().ToImage<Gray, byte>();
                    Mat dst = new Mat();
                    Mat mask = new Mat();
                    CvInvoke.MatchTemplate(imgSrc, imgTemplate, dst, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed, mask);
                    double minVal = 0.0;
                    double maxVal = 0.0;
                    Point minLoc = new Point();
                    Point maxLoc = new Point();
                    double MinMatchQuality = 0.5;
                    CvInvoke.MinMaxLoc(dst, ref minVal, ref maxVal, ref minLoc, ref maxLoc, mask);
                    if (maxVal > MinMatchQuality)
                    {
                        Rectangle r = new Rectangle(maxLoc, imgTemplate.Size);
                        CvInvoke.Rectangle(imgSrc, r, new MCvScalar(0, 0, 255), 5);
                        pictureBox1.Image = imgSrc.ToBitmap();
                        wyjscie = 1;

                    }
                    else
                    {
                        tb_Wiad.Text = "Brak";
                        pictureBox1.Image = imgSrc.ToBitmap();
                        wyjscie = 0;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
