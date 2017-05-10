using Framework.Driver;
using OpenQA.Selenium;

namespace Framework.Elements
{
    public class Element
    {
        private IWebElement _element => DriverManager.Driver.FindElement(Search);

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
