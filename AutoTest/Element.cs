using OpenQA.Selenium;

namespace Framework
{
    public class Element
    {
        private IWebElement _element => DriverManager.FindElement(_search);
        internal By _search;

        internal Element()
        {
        }

        public Element ElementFactory(string elementXPath)
        {
            _search = By.XPath(elementXPath);
            return this;
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
