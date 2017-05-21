using System;
using System.Drawing;
using System.Drawing.Imaging;
using Framework.Driver;
using Framework.Elements;
using OpenQA.Selenium;

namespace Framework
{
    public static class ScreenshotMaker
    {
        public static void TakeScreenshot(Element focusedElement = null)
        {
            String fileName = "Failure" + DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            Byte[] byteArray = ((ITakesScreenshot)DriverManager.Driver).GetScreenshot().AsByteArray;
            Bitmap screenshot = new Bitmap(new System.IO.MemoryStream(byteArray));

            if (focusedElement != null)
            {
                Rectangle croppedImage = new Rectangle(focusedElement.Location.X, focusedElement.Location.Y, focusedElement.Width, focusedElement.Height);
                screenshot = screenshot.Clone(croppedImage, screenshot.PixelFormat);

            }
            screenshot.Save(fileName + ".png", ImageFormat.Png);
        }
    }
}
