using System;
using Framework;
using Framework.Elements;

namespace UI.Common
{
    public abstract class Selector
    {
        protected string _selectorXPathFormat;
        protected string _selectorOptionXPathFormat;

        protected Element _selector;
        private Element _option;

        internal Selector()
        {
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
