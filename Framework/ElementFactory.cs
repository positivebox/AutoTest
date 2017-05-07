namespace Framework
{
    public static class ElementFactory
    {
        public static Element InitializeElement(string locator, SearchBy locatorValue = SearchBy.Xpath)
        {
            Element element = new Element();
            element.Search = new Search(locator);
            return element;
        }
    }
}
