using System;
using System.Drawing;
using OpenCvSharp;
using OpenCvSharp.Extensions;

namespace WebCamImages
{
	public class WebCamFrameGrabber :IDisposable
	{
		public WebCamFrameGrabber(int cameraIndex)
		{
			frame = new Mat();
			capture = new VideoCapture(cameraIndex);
			capture.Open(cameraIndex);
		}

		private readonly Mat frame;
		private readonly VideoCapture capture;

		public Bitmap GetImageFromFrame()
		{
			capture.Read(frame);
			return frame.ToBitmap();
		}

		public void Dispose()
		{
			frame?.Dispose();
			capture?.Dispose();
		}
	}
}