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
    internal class Program
    {
        static void Main(string[] args)
        {
            CameraModule cameraModule = new CameraModule();
            try
            {
                cameraModule.Init();
                var captureImage = cameraModule.Capture(save: true);
                var manipulatedImage = cameraModule.Manipulate(captureImage);
                cameraModule.ShowImage(captureImage);
                cameraModule.ShowImage(manipulatedImage);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                cameraModule.Release();
            }
        }
    }
}
