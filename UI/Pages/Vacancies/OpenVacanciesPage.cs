using System.Collections.Generic;
using Framework.Elements;
using UI.Common;

namespace UI.Pages.Vacancies
{
    public class OpenVacanciesPage : BasePage
    {
        public PageDropdown DirectionDropdown = new PageDropdown("direction");
        public PageDropdown TechnologyDropdown = new PageDropdown("lang");
        public PageDropdown CountryDropdown = new PageDropdown("country");
        public PageDropdown CityDropdown = new PageDropdown("city");
        private const string VacancyCardsXPath = "//div[contains(@class, 'card-vacancy')]";

        public List<VacancyCardSection> VacancyCards
        {
            get
            {
                var vacancyCards = new List<VacancyCardSection>();
                for (int i = 1; i <= ElementFactory
                    .InitializeElements(VacancyCardsXPath).Count; i++)
                {
                    vacancyCards.Add(new VacancyCardSection(i));
                }
                return vacancyCards;
            }
        }

        internal OpenVacanciesPage()
        {
            Url = "https://softserve.ua/ua/vacancies/open-vacancies/";
        }
    }
}
