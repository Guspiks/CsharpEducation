using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Basler.Pylon;
using System.Diagnostics;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using Emgu.CV.Features2D;


namespace wykrywaniekształtu
{
    public partial class Form1 : Form
    {   
        private Camera camera = null;
        private PixelDataConverter converter = new PixelDataConverter();
        private Stopwatch stopWatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ContinousShot()
        {
            try
            {
                Configuration.AcquireContinuous(camera, null);
                camera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
            catch (Exception exception)
            {
                ShowExeptcion(exception);
            }
        }
        private void ShowExeptcion(Exception exception)
        {
            MessageBox.Show("Exception caught:\n" + exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void OneShot()
        {
            try
            {
                Configuration.AcquireSingleFrame(camera, null);
                camera.StreamGrabber.Start(1, GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
            catch (Exception exception)
            {
                ShowExeptcion(exception);
            }
        }
        private void Stop()
        {
            try
            {
                camera.StreamGrabber.Stop();
            }
            catch (Exception exception)
            {
                ShowExeptcion(exception);
            }
        }
        private void DestroyCamera()
        {
            //Wyłącza kamere
            try
            {
                if (camera != null)
                {
                    camera.Close();
                    camera.Dispose();
                    camera = null;
                }
            }
            catch (Exception exception)
            {
                ShowExeptcion(exception);
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
                camera.CameraClosed += OnCameraClosed;
                camera.StreamGrabber.GrabStarted += OnGrabStarted;
                camera.StreamGrabber.ImageGrabbed += OnImageGrabbed;
                camera.StreamGrabber.GrabStopped += OnGrabStopped;

                camera.Open();
                camera.Parameters[PLCamera.Width].SetValue(600);
                camera.Parameters[PLCamera.Height].SetValue(600);
                camera.Parameters[PLCamera.CenterX].SetValue(true);
                camera.Parameters[PLCamera.CenterY].SetValue(true);
            }
            catch(Exception exception)
            {
                ShowExeptcion(exception);
            }
        }
        private void OnGrabStopped(Object sender, GrabStopEventArgs e)
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
        private void OnImageGrabbed(Object sender, ImageGrabbedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<ImageGrabbedEventArgs>(OnImageGrabbed), sender, e.Clone());
                return;
            }
            try
            {
                //Pobieramy zdjęcia z kamery, pokazuje zawsze ostatnie zdjecie, kamera moze zrobic wiecej zdjec nim mozna je wyswietlic
                //zbieramy wynik z GRAB
                IGrabResult grabResult = e.GrabResult;

                //Sprawdzamy czy zdjecie mozna wyświetlić
                if (grabResult.IsValid)
                {
                    //Zmniejszamy ilosc wyswietlanych zdjec
                    if (!stopWatch.IsRunning || stopWatch.ElapsedMilliseconds > 33)
                    {
                        stopWatch.Restart();

                        Bitmap bitmap = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
                        //Blokujemy ilość bitów na bitmapie
                        BitmapData bmpData = bitmap.LockBits(new Rectangle(0, 0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
                        //Kładziemy pointer w strone bufora bitmap
                        converter.OutputPixelFormat = PixelType.BGRA8packed;
                        IntPtr ptrBmp = bmpData.Scan0;
                        converter.Convert(ptrBmp, bmpData.Stride * bitmap.Height, grabResult);
                        bitmap.UnlockBits(bmpData);

                        //przypisujemy nowa zmienna by pozbyc sie bit mapy po przypisaniu nowej do wyswietlenia
                        Bitmap bitmapOld = pictureBox1.Image as Bitmap;
                        //dodajemy nowe bitmapy do display control. Akcja ta aktualizuje obraz autoamtycznie
                        pictureBox1.Image = bitmap;
                        if (bitmapOld != null)
                        {
                            //Usuwamy bitmape
                            bitmapOld.Dispose();
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                ShowExeptcion(exception);
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
                    if (maxVal>MinMatchQuality)
                    {
                        Rectangle r = new Rectangle(maxLoc, imgTemplate.Size);
                        CvInvoke.Rectangle(imgSrc, r, new MCvScalar(0, 0, 255), 5);
                        pictureBox1.Image = imgSrc.ToBitmap();
                    }
                    else
                    {
                        tb_Wiad.Text = "Brak";
                        pictureBox1.Image = imgSrc.ToBitmap();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        private void bt_con_Click(object sender, EventArgs e)
        {
            Connect();
        }

        private void bt_dis_Click(object sender, EventArgs e)
        {
            DestroyCamera();
        }

        private void bt_oneshot_Click(object sender, EventArgs e)
        {
            OneShot();
        }

        private void bt_conshot_Click(object sender, EventArgs e)
        {
            ContinousShot();
        }

        private void bt_stop_Click(object sender, EventArgs e)
        {
            Stop();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DestroyCamera();
        }

        private void bt_wykryj_Click(object sender, EventArgs e)
        {
            TemplateMatching();
        }
    }
}
