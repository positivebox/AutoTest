using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Framework.Elements;
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Framework.Driver
{
    public class Driver
    {
        internal IWebDriver _driver;

        internal Driver(Browser browser)
        {
            switch (browser)
            {
                case Browser.Chrome:
                    _driver = new ChromeDriver(@"C:\Users\Natalka1992\Desktop\Training\AutoTest\driver");
                    break;
                default:
                    _driver = new ChromeDriver(@"C:\Users\Natalka1992\Desktop\Training\AutoTest\driver");
                    break;
            }
        }

        public void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        internal IWebElement FindElement(Search search)
        {
            return _driver.FindElement(search.By);
        }

        internal List<IWebElement> FindElements(Search search)
        {
            List<IWebElement> elements = new List<IWebElement>();
            foreach (var element in _driver.FindElements(search.By))
            {
                elements.Add(element);
            }

            return elements;
        }

        public void TakeScreenshot(Element focusedElement = null)
        {
            String fileName = "Failure" + DateTime.Now.ToString("yyyy-MM-dd-hhmm-ss");
            Byte[] byteArray = ((ITakesScreenshot)_driver).GetScreenshot().AsByteArray;
            Bitmap screenshot = new Bitmap(new System.IO.MemoryStream(byteArray));

            if (focusedElement != null)
            {
                Rectangle croppedImage = new Rectangle(focusedElement.Location.X, focusedElement.Location.Y, focusedElement.Width, focusedElement.Height);
                screenshot = screenshot.Clone(croppedImage, screenshot.PixelFormat);

            }
            screenshot.Save(fileName + ".png", ImageFormat.Png);
        }

        public void Quit()
        {
            _driver.Quit();
        }
    }

    public enum Browser
    {
        Chrome
    }
}
