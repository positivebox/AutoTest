using OpenQA.Selenium;

namespace Framework
{
    public class Search
    {
        public By By { get; private set; }

        internal Search(string locatorValue, SearchBy locator = SearchBy.Xpath)
        {
            switch (locator)
            {
                case (SearchBy.Id):
                    By = By.Id(locatorValue);
                    break;
                case (SearchBy.Xpath):
                    By = By.XPath(locatorValue);
                    break;
                default:
                    By = By.XPath(locatorValue);
                    break;
            }
        }
    }

    public enum SearchBy
    {
        Xpath,
        Id
    }
}
