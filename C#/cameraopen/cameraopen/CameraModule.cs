using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenCvSharp;
using OpenCvSharp.Blob;
using OpenCvSharp.Extensions;
using OpenCvSharp.UserInterface;

namespace cameraopen
{
    internal class CameraModule
    {
        FrameSource frameSource;
        public void Init()
        {
            frameSource = Cv2.CreateFrameSource_Camera(1);
        }
        public Mat Capture(bool save)
        {
            Mat img = new Mat();
            frameSource.NextFrame(img);
            if (save)
            {
                string imagePath = string.Format("{1}\\cam.jpg", AppDomain.CurrentDomain.BaseDirectory);
                img.SaveImage(imagePath);
            }
            return img;
        }
        public Mat Manipulate(Mat image)
        {
            Mat edgeDetection = new Mat();
            Cv2.Canny(image, edgeDetection, 100, 200);
            return edgeDetection;
        }
        public void ShowImage(Mat image)
        {
            Cv2.ImShow("img", image);
            Cv2.WaitKey(0);
        }
        public void Release()
        {
            Cv2.DestroyAllWindows();
        }
    }
}
