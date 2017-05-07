using OpenQA.Selenium;

namespace Framework
{
    public class Element
    {
        private IWebElement _element => DriverManager.FindElement(Search);

        internal Search Search;

        internal Element()
        {
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
