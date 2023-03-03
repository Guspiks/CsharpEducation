using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.UI;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System.Drawing.Imaging;

namespace ObjRec
{
    public partial class Form1 : Form
    {
        Image<Bgr, byte> imgImput;
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_Open_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog()==DialogResult.OK)
                {
                    imgImput = new Image<Bgr, byte>(openFile.FileName);
                    picbox_Original.Image = imgImput.ToBitmap();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Contour_Detection()
        {
            try
            {
                var temp = imgImput.SmoothGaussian(5).Convert<Gray, byte>().ThresholdBinaryInv(new Gray(200), new Gray(255));
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat m = new Mat();

                CvInvoke.FindContours(temp, contours, m, Emgu.CV.CvEnum.RetrType.Ccomp, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                for (int i = 0; i < contours.Size; i++)
                {
                    double perimeter = CvInvoke.ArcLength(contours[i], true);
                    VectorOfPoint approx = new VectorOfPoint();
                    CvInvoke.ApproxPolyDP(contours[i], approx, 0.04 * perimeter, true);

                    CvInvoke.DrawContours(imgImput, contours, i, new MCvScalar(0, 255, 255));
                    picbox_Detected.Image = imgImput.ToBitmap();

                    var moments = CvInvoke.Moments(contours[i]);
                    int x =(int)(moments.M10 / moments.M00);
                    int y =(int)(moments.M01 / moments.M00);

                    if(approx.Size == 3)
                    {
                        CvInvoke.PutText(imgImput,"Trojkat",new Point(x,y),Emgu.CV.CvEnum.FontFace.HersheySimplex,0.5,new MCvScalar(0, 255, 255),2);
                    }

                    if (approx.Size == 4)
                    {
                        Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                        double ar= (double)(rect.Width / rect.Height);
                        if (ar >= 0.95 && ar <= 1.05)
                        {
                            CvInvoke.PutText(imgImput, "Kwadrat", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 255, 255), 2);
                        }
                        else
                        {
                            CvInvoke.PutText(imgImput, "Kwadrat", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 255, 255), 2);
                        }
                    }

                    if (approx.Size > 4)
                    {
                        CvInvoke.PutText(imgImput, "Wielokat", new Point(x, y), Emgu.CV.CvEnum.FontFace.HersheySimplex, 0.5, new MCvScalar(0, 255, 255), 2);
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_Wykryj_Click(object sender, EventArgs e)
        {
            if (imgImput == null)
            {
                return;
            }
            try
            {
                Contour_Detection();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void MatchTemplate()
        {
            if(imgImput == null)
            {
                return;
            }

            try
            {
                var src = imgImput.Clone();
                string template = "monotest.png";
                Mat imgTemplate = CvInvoke.Imread(template);
                Mat dst = new Mat();
                Mat mask = new Mat();
                CvInvoke.MatchTemplate(src, imgTemplate, dst, Emgu.CV.CvEnum.TemplateMatchingType.CcoeffNormed, mask);
                double minVal = 0.0;
                double maxVal = 0.0;
                Point minLoc = new Point();
                Point maxLoc = new Point();
                double minMatchQuality = 0.2;
                CvInvoke.MinMaxLoc(dst, ref minVal, ref maxVal, ref minLoc, ref maxLoc, mask);
                if (maxVal > minMatchQuality)
                {
                    Rectangle r = new Rectangle(maxLoc, imgTemplate.Size);
                    CvInvoke.Rectangle(src, r, new MCvScalar(0, 0, 255), 10);
                    picbox_Detected.Image = src.ToBitmap();
                    tb_maxVal.Text = maxLoc.ToString();
                    tb_minVal.Text = minLoc.ToString();
                    textBox1.Text = minVal.ToString();
                    textBox2.Text = maxVal.ToString();
                }
                else
                {
                    tb_Wynik.Text = "nie znaleziono";
                    picbox_Detected.Image = src.ToBitmap();
                    tb_maxVal.Text = maxLoc.ToString();
                    tb_minVal.Text = minLoc.ToString();
                    textBox1.Text = minVal.ToString();
                    textBox2.Text = maxVal.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bt_macz_Click(object sender, EventArgs e)
        {
            MatchTemplate();
        }

        private void bt_Save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "JPEG files(*.jpeg)|*.jpeg";
            if(DialogResult.OK == sfd.ShowDialog())
            {
                this.picbox_Detected.Image.Save(sfd.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
