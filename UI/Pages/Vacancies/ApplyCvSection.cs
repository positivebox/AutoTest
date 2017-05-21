using Framework;
using Framework.Elements;
using UI.Common;

namespace UI.Pages.Vacancies
{
    public class ApplyCvSection
    {
        private const string SubmitCvButtonXPath = "//input[@class='submit']";
        private const string FileExtentionIncorrectMessageXPath = "//p[text() ='Допустимі розширення файлів: doc, docx, rtf, odf, pdf']";

        public Element EmailField { get { return ElementFactory
                    .InitializeElement("//input[@name='email']"); } }
        public Element ChooseFileButton { get { return ElementFactory
                    .InitializeElement("//input[@name='resume']"); } }
        public FormDropdown WhereFromDropdown { get { return new FormDropdown("wherefrom"); } }

        public void SubmitCv()
        {
            ElementFactory.InitializeElement(SubmitCvButtonXPath).Click();
            Logger.Info("Clicking Submit CV button");
        }

        public bool VerifyFileExtentionIncorrectMessageAppeared()
        {
            return ElementFactory.InitializeElement(FileExtentionIncorrectMessageXPath).Displayed;
        }
    }
}
