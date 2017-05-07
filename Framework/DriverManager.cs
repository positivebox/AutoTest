using OpenQA.Selenium;

namespace Framework
{
    public static class DriverManager
    {
        private static Driver _driver;

        public static void SelectDriver(Browser browser)
        {
            _driver = new Driver(browser);
        }

        public static void OpenUrl(string url)
        {
            _driver.OpenUrl(url);
        }

        internal static IWebElement FindElement(Search search)
        {
            return _driver.FindElement(search);
        }

        public static void Quit()
        {
            _driver._driver.Quit();
        }
    }
}
