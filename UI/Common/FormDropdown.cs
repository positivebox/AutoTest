using System;
using Framework.Elements;

namespace UI.Common
{
    public class FormDropdown : Selector
    {
        internal FormDropdown(string name) : base()
        {
            _selectorXPathFormat = String.Format("//select[@name='{0}']", name);
            _selectorOptionXPathFormat = String.Format("//select[@name='{0}']", name) + "/option[contains(text(),'{0}')]";
            _selector = ElementFactory
                .InitializeElement(_selectorXPathFormat);
        }
    }
}
