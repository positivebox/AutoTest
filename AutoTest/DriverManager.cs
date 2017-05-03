using OpenQA.Selenium;

namespace Framework
{
    public static class DriverManager
    {
        private static IWebDriver _driver;

        public static void SelectDriver(IWebDriver driver)
        {
            _driver = driver;
        }

        public static void OpenUrl(string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        public static void Quit()
        {
            _driver.Quit();
        }

        internal static IWebElement FindElement(By search)
        {
            return _driver.FindElement(search);
        }
    }
}
