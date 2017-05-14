using System;

namespace UI.Common
{
    public class PageDropdown : Selector
    {
        internal PageDropdown(string idTax): base(idTax)
        {
            _selectorXPathFormat = String.Format("//*[@id='s2id_tax-{0}']/a", idTax);
            _selectorOptionXPathFormat = String.Format("//select[@id='tax-{0}']", idTax) +"/option[contains(text(),'{0}')]";
        }
    }
}
