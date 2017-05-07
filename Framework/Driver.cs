using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Framework
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
    }

    public enum Browser
    {
        Chrome
    }
}
