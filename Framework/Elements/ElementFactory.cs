namespace Framework.Elements
{
    public static class ElementFactory
    {
        public static Element InitializeElement(string locator, SearchBy locatorValue = SearchBy.Xpath)
        {
            Element element = new Element();
            element.Search = new Search(locator);
            return element;
        }

        public static ElementsList InitializeElements(string locator, SearchBy locatorValue = SearchBy.Xpath)
        {
            ElementsList elements = new ElementsList();
            elements.Search = new Search(locator);
            return elements;
        }
    }
}
