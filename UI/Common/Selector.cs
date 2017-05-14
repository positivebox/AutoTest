using System;
using Framework.Elements;
using Framework;

namespace UI.Common
{
    public abstract class Selector
    {
        protected string _selectorXPathFormat;
        protected string _selectorOptionXPathFormat;

        private Element _selector;
        private Element _option;

        internal Selector(string identifier)
        {
            _selector = ElementFactory
                .InitializeElement(String.Format(_selectorXPathFormat, identifier));
        }

        public void SelectDropdownOption(string optionValue)
        {
            _selector.Click();
            _option = ElementFactory
                .InitializeElement(String.Format(_selectorOptionXPathFormat, optionValue));
            _option.Click();
            Logger.Info(String.Format("'{0}' dropdown option selected", optionValue));
        }
    }
}
