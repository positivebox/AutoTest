using Framework;
using Framework.Elements;

namespace UI.Pages.Vacancies
{
    public class VacancyPage: BasePage
    {
        private int _cardIndex;

        private const string VacancyPageTitleXPath = "//h2[@class = 'card-vacancy-prev_title']";
        private const string VacancyPageDirectionsXPath = "//div/div/dl[1]/dd";
        private const string VacancyPageCountryXPath = "//div/div/dl[2]/dd";
        private const string VacancyPageCityXPath = "//div/div/dl[3]/dd";
        private const string ApplyCvButtonXPath = "//div[@class='button-vacancy']/a[1]";

        public ApplyCvSection ApplyCVSection { get; private set; }

        internal VacancyPage()
        {
        }

        public string GetTitle()
        {
            return ElementFactory.InitializeElement(VacancyPageTitleXPath)
                .GetInnerText();
        }

        public string GetDirections()
        {
            return ElementFactory.InitializeElement(VacancyPageDirectionsXPath)
                .GetInnerText();
        }

        public string GetCountry()
        {
            return ElementFactory.InitializeElement(VacancyPageCountryXPath)
                .GetInnerText();
        }

        public string GetCity()
        {
            return ElementFactory.InitializeElement(VacancyPageCityXPath)
                .GetInnerText();
        }

        public void OpenApplyCvSection()
        {
            ElementFactory.InitializeElement(ApplyCvButtonXPath).Click();
            Logger.Info("Clicking Apply CV button");
            ApplyCVSection = new ApplyCvSection();
        }
    }
}
