using Framework;
using System;

namespace UI.Common
{
    internal class Dropdown
    {
        private string _dropdownOptionXPathFormat;

        private Element _dropdown;
        private Element _option;

        internal Dropdown(string idTax)
        {
            _dropdown = ElementFactory
                .InitializeElement(String.Format("//*[@id='s2id_tax-{0}']/a", idTax));
            _dropdownOptionXPathFormat = String.Format("//select[@id='tax-{0}']", idTax) +"/option[contains(text(),'{0}')]";
        }

        public void SelectDropdownOption(string optionValue)
        {
            _dropdown.Click();
            _option = ElementFactory
                .InitializeElement(String.Format(_dropdownOptionXPathFormat, optionValue));
            _option.Click();
        }
    }
}
