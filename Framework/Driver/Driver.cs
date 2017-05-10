using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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
