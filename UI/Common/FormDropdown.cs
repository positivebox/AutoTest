﻿using System;

namespace UI.Common
{
    public class FormDropdown : Selector
    {
        internal FormDropdown(string name) : base(name)
        {
            _selectorXPathFormat = String.Format("//select[@name='{0}']", name);
            _selectorOptionXPathFormat = String.Format("//select[@name='{0}']", name) + "/option[contains(text(),'{0}')]";
        }
    }
}