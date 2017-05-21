using Framework.Driver;
using OpenQA.Selenium;
using System.Drawing;

namespace Framework.Elements
{
    public class Element
    {
        private IWebElement _element => DriverManager.Driver.FindElement(Search);

        public int Width { get { return _element.Size.Width; } }
        public int Height { get { return _element.Size.Height; } }

        public bool Displayed {get { return _element.Displayed; } }

        public Point Location { get { return _element.Location; } }

        internal Search Search;

        internal Element()
        {
        }

        public string GetInnerText()
        {
            return _element.Text;
        }

        public void SendKeys(string text)
        {
            _element.SendKeys(text);
        }

        public void Click()
        {
            _element.Click();
        }
    }
}
