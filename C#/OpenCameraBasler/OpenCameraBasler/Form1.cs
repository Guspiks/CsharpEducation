using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Basler.Pylon;

namespace OpenCameraBasler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Get_Click(object sender, EventArgs e)
        {
            string FirmwareVer = "1";
            string ModelName = "1";
            string VendorName = "1";
            //Stworzenie obiektu kamery która uzywa pierwszej kamery którą wykryje
            using (Camera camera = new Camera())
                {
                    //wystartowanie kamery
                    camera.Open();
                    {
                        FirmwareVer = camera.Parameters[PLCamera.DeviceFirmwareVersion].GetValue();
                        ModelName = camera.Parameters[PLCamera.DeviceModelName].GetValue();
                        VendorName = camera.Parameters[PLCamera.DeviceVendorName].GetValue();
                    }
                    camera.Close();
                    camera.Dispose();
            }
            tb_Parametry.Text = "Informacje urządzenia kamery";
            tb_Parametry.Text = "============================";
            tb_Parametry.Text = "Vendor             :{0} " + VendorName;
            tb_Parametry.Text = "Model              :{0} " + ModelName;
            tb_Parametry.Text = "Firmware Version   :{0} " + FirmwareVer;
            tb_Parametry.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tb_Parametry.Text = "test";
        }
    }
}
