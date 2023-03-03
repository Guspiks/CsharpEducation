using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;

namespace aforgecamtrest
{
    public partial class Form1 : Form
    {
        MJPEGStream streamVideo;
        public Form1()
        {
            InitializeComponent();
            streamVideo = new MJPEGStream("192.168.3.3:3956");
            streamVideo.NewFrame += GetNewFrame;
        }

        private void GetNewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bmp = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bmp;
        }

        private void bt_Start_Click(object sender, EventArgs e)
        {
            streamVideo.Start();
        }

        private void bt_Stop_Click(object sender, EventArgs e)
        {
            streamVideo.Stop();
        }
    }
}
