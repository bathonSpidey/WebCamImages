using System.Drawing.Imaging;
using NUnit.Framework;

namespace WebCamImages
{
	public class WebCamFrameGrabberTests
	{
		[Test]
		public void SaveImageFromWebcam()
		{
			var camera = new WebCamFrameGrabber(0);
			var image = camera.GetImageFromFrame();
			image.Save(@"test.png", ImageFormat.Png);
			Assert.That(image.Width, Is.EqualTo(640));
			Assert.That(image.Height, Is.EqualTo(480));
			camera.Dispose();
		}
	}
}