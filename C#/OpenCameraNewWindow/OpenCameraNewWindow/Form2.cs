using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DarrenLee.Media;

namespace OpenCameraNewWindow
{
    public partial class Form2 : Form
    {   
        int count = 0;
        Camera myCamera = new DarrenLee.Media.Camera();
        public Form2()
        {
            InitializeComponent();

            GetInfo();
            myCamera.OnFrameArrived += MyCamera_OnFrameArrived;
        }

        private void GetInfo()
        {
            var cameraDevices = myCamera.GetCameraSources();
            var cameraResolution = myCamera.GetSupportedResolutions();

            foreach (var d in cameraDevices)
                cmbCameraDevices.Items.Add(d);

            foreach (var r in cameraResolution)
                cmbCameraResolution.Items.Add(r);

            cmbCameraDevices.SelectedIndex = 0;
            cmbCameraResolution.SelectedIndex = 0;
        }

        private void MyCamera_OnFrameArrived(object source, FrameArrivedEventArgs e)
        {
            Image img = e.GetFrame();
            pictureBox1.Image = img;
        }

        private void bt_CloseCamera_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbCameraDevices_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.ChangeCamera(cmbCameraDevices.SelectedIndex);
        }

        private void cmbCameraResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            myCamera.Start(cmbCameraDevices.SelectedIndex);
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            myCamera.Stop();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            string filename = Application.StartupPath + @"\" + "Image" + count.ToString();
            myCamera.Capture(filename);
            count++;
        }
    }
}
