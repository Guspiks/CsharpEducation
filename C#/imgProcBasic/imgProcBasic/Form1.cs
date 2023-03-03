using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace imgProcBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Otwieranie zdjęć za pomocą przycisku i wyboru pliku
        private void bt_Open_Click(object sender, EventArgs e)
        {
            OpenFileDialog Opfile = new OpenFileDialog();
            Opfile.Filter = "Image File (*.bmp,*.png)| *.bmp;*.png";
            if (DialogResult.OK == Opfile.ShowDialog())
            {
                this.picbox_Original.Image = new Bitmap(Opfile.FileName);
            }
        }
    }
}
