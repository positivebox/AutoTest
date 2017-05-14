using Framework;
using Framework.Elements;
using UI.Common;

namespace UI.Pages.Vacancies
{
    public class ApplyCvSection
    {
        private const string SubmitCvButtonXPath = "//input[@class='submit']";

        public Element EmailField = ElementFactory
            .InitializeElement("//select[@name='email']");
        public FormDropdown WhereFromDropdown = new FormDropdown("wherefrom");

        public void SubmitCv()
        {
            ElementFactory.InitializeElement(SubmitCvButtonXPath).Click();
            Logger.Info("Clicking Submit CV button");
        }
    }
}
