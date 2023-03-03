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

namespace terazzadiała
{
    public partial class Form1 : Form
    {
        private Camera camera = null;
        private PixelDataConverter converter = new PixelDataConverter();
        private Stopwatch stopWatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();

            UpdateDeviceList();

            EnableButtons(false, false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ContinousShot()
        {
            try
            {
                Configuration.AcquireContinuous(camera, null);
                camera.StreamGrabber.Start(GrabStrategy.OneByOne, GrabLoop.ProvidedByStreamGrabber);
            }
            catch(Exception exception)
            {
                ShowExeptcion(exception);
            }
        }
        private void ShowExeptcion(Exception exception)
        {
            MessageBox.Show("Exception caught:\n"+exception.Message, "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void bt_Start_Click(object sender, EventArgs e)
        {
            ContinousShot();
        }

        private void bt_OneShot_Click(object sender, EventArgs e)
        {
            OneShot();
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            Stop();
        }
        //Funkcja do aktualizowania listy kamer
        private void UpdateDeviceList()
        {
            try
            {
                //Zapyatnie do funkcji CameraFinder o liste wszystkich kamer
                List<ICameraInfo> allCameras = CameraFinder.Enumerate();

                ListView.ListViewItemCollection items = lv_Device.Items;

                //sprawdzamy wszystkie kamery w liscie
                foreach(ICameraInfo cameraInfo in allCameras)
                {
                    bool newitem = true;
                    foreach(ListViewItem item in items)
                    {
                        ICameraInfo tag = item.Tag as ICameraInfo;

                        //Sprawdzanie czy kamera jest już na liscie?
                        if(tag[CameraInfoKey.FullName] == cameraInfo[CameraInfoKey.FullName])
                        {
                            tag = cameraInfo;
                            newitem = false;
                            break;
                        }
                    }

                    //Jeżeli nie ma kamery na liscie dodajemy ją na nią.
                    if (newitem)
                    {
                        //Tworzymy przedmiot do wyświetlenia
                        ListViewItem item = new ListViewItem(cameraInfo[CameraInfoKey.FriendlyName]);

                        //Tworzymy tool tip text
                        string toolTipText = "";
                        foreach (KeyValuePair<string, string> kvp in cameraInfo)
                        {
                            toolTipText += kvp.Key + ": " + kvp.Value + "\n";
                        }
                        item.ToolTipText = toolTipText;

                        //Zamieszczamy informacje na temat kamery w wyswietlanym przedmiocie
                        item.Tag = cameraInfo;

                        //Dodajemy informacje
                        lv_Device.Items.Add(item);
                    }
                }


                //Usuwanie starych kamer które są rozłączone
                foreach (ListViewItem item in items)
                {
                    bool exists = false;

                    //Dla każdej kamery sprawdź czy da się je znaleźć za pomocą enumaration
                    foreach(ICameraInfo cameraInfo in allCameras)
                    {
                        if(((ICameraInfo)item.Tag)[CameraInfoKey.FullName] == cameraInfo[CameraInfoKey.FullName])
                        {
                            exists = true;
                            break;
                        }
                    }
                    //Jeżeli nie znalzeziono kamery usunąć z listy
                    if (!exists)
                    {
                        lv_Device.Items.Remove(item);
                    }
                }
            }
            catch (Exception exception)
            {
                ShowExeptcion(exception);
            }
        }
        //Zmienia czy przyciski sa dostępne
        private void EnableButtons(bool canGrab, bool canStop)
        {
            bt_Start.Enabled = canGrab;
            bt_OneShot.Enabled = canGrab && IsSingleShotSupported();
            bt_Stop.Enabled = canStop;
            bt_Save.Enabled = canGrab && IsSingleShotSupported();
        }
        //Sprawdza czy kamera obsługuje pojedyńcze zdjęcie
        private bool IsSingleShotSupported()
        {
            //Camera może mieć status null gdy jeszcze jest nie otwarta
            if (camera == null)
            {
                return false;
            }

            //Kamera może być zamknięta
            if (!camera.IsOpen)
            {
                return false;
            }

            bool canSet = camera.Parameters[PLCamera.AcquisitionMode].CanSetValue("SingleFrame");
            return canSet;
        }
        //Wyłącza kamerę
        private void DestroyCamera()
        {
            //Wyłącza kamere
            try
            {
                if(camera != null)
                {
                    camera.Close();
                    camera.Dispose();
                    camera = null;
                }
            }
            catch(Exception exception)
            {
                ShowExeptcion(exception);
            }
        }
        //Zalącza się gdy kamera straci połaczenie
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
            //Z powodu zamknięcia kamery powiniśmy zaktualizować liste
            UpdateDeviceList();
        }
        //Załącza się gdy kamera nawiąże połącznie
        private void OnCameraOpened(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OnCameraOpened), sender, e);
                return;
            }
            //Kamera gotowa więc odblokowujemy przyciski
            EnableButtons(true, false);
        }
        private void OnCameraClosed(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs>(OnCameraClosed), sender, e);
                return;
            }
            //Kamera wyłaczona więc blokowujemy przyciski
            EnableButtons(false, false);
        }
        private void OnGrabStarted(Object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<EventArgs> (OnGrabStarted), sender, e);
                return ;
            }
            //Resetuje stopWatch by zmniejszyc ilosc wyswietlanych obrazów 
            stopWatch.Reset();
            //Wyłączamy aktualizowanie listy gdy bedziemy łapać bitmapy
            updateDeviceListTimer.Stop();
            //Kamera łapie obrazy więc dezaktywujemy przyciski i aktywujemy przycisk stop
            EnableButtons(false, true);
        }
        //Jest aktywne gdy kamera łapie bitmapy
        private void OnImageGrabbed(Object sender, ImageGrabbedEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<ImageGrabbedEventArgs>(OnImageGrabbed), sender, e.Clone() );
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
                    if(!stopWatch.IsRunning || stopWatch.ElapsedMilliseconds > 33)
                    {
                        stopWatch.Restart();

                        Bitmap bitmap = new Bitmap(grabResult.Width, grabResult.Height, PixelFormat.Format32bppRgb);
                        //Blokujemy ilość bitów na bitmapie
                        BitmapData bmpData = bitmap.LockBits(new Rectangle(0,0, bitmap.Width, bitmap.Height), ImageLockMode.ReadWrite, bitmap.PixelFormat);
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
        //uzywane gdy kamera przestaje łapac obraz
        private void OnGrabStopped(Object sender, GrabStopEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new EventHandler<GrabStopEventArgs>(OnGrabStopped), sender, e);
                return;
            }

            //resetujemy stopwacht
            stopWatch.Reset();

            //Włączamy aktualizowanie listy urządzeń
            updateDeviceListTimer.Start();

            //włączamy przyciski
            EnableButtons(true, false);

            //Jezeli kamera przestała łapac obrazy wyswietlamy bląd
            if(e.Reason != GrabStopReason.UserRequest)
            {
                MessageBox.Show("A grab error occured:\n"+ e.ErrorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs ev)
        {
            DestroyCamera();
        }

        private void lv_Device_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(camera != null)
            {
                DestroyCamera();
            }

            if(lv_Device.SelectedItems.Count > 0)
            {
                ListViewItem item = lv_Device.SelectedItems[0];

                ICameraInfo selectedCamera = item.Tag as ICameraInfo;
                try
                {
                    camera = new Camera(selectedCamera);

                    camera.CameraOpened += Configuration.AcquireContinuous;

                    camera.ConnectionLost += OnConnectionLost;
                    camera.CameraOpened += OnCameraOpened;
                    camera.CameraClosed += OnCameraClosed;
                    camera.StreamGrabber.GrabStarted += OnGrabStarted;
                    camera.StreamGrabber.ImageGrabbed += OnImageGrabbed;
                    camera.StreamGrabber.GrabStopped += OnGrabStopped;

                    camera.Open();
                }
                catch(Exception exeption)
                {
                    ShowExeptcion(exeption);
                }
            }
        }

        private void lv_Device_KeyDown(object sender, KeyEventArgs ev)
        {
            if (ev.KeyCode == Keys.F5)
            {
                ev.Handled = true;
                UpdateDeviceList();
            }
        }

        private void updateDeviceListTimer_Tick(object sender, EventArgs e)
        {
            UpdateDeviceList();
        }

        private void bt_Connect_Click(object sender, EventArgs e)
        {
            UpdateDeviceList();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG files(*.jpeg)|*.jpeg";//zapisywanie w formacie jpeg
            if (DialogResult.OK == sfd.ShowDialog())
            {
                this.pictureBox1.Image.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
