using System.Collections.Generic;
using Framework.Elements;
using UI.Common;

namespace UI.Pages.Vacancies
{
    public class OpenVacanciesPage : BasePage
    {
        private Dropdown _directionDropdown = new Dropdown("direction");
        private Dropdown _technologyDropdown = new Dropdown("lang");
        private Dropdown _countryDropdown = new Dropdown("country");
        private Dropdown _cityDropdown = new Dropdown("city");
        private const string VacancyCardsXPath = "//div[contains(@class, 'card-vacancy')]";

        public List<VacancyCard> VacancyCards
        {
            get
            {
                var vacancyCards = new List<VacancyCard>();
                for (int i = 1; i <= ElementFactory
                    .InitializeElements(VacancyCardsXPath).Count; i++)
                {
                    vacancyCards.Add(new VacancyCard(i));
                }
                return vacancyCards;
            }
        }

        internal OpenVacanciesPage()
        {
            Url = "https://softserve.ua/ua/vacancies/open-vacancies/";
        }

        public void SelectDirection(string direction)
        {
            _directionDropdown.SelectDropdownOption(direction);
        }

        public void SelectTechnology(string technology)
        {
            _technologyDropdown.SelectDropdownOption(technology);
        }

        public void SelectCountry(string country)
        {
            _countryDropdown.SelectDropdownOption(country);
        }

        public void SelectCity(string city)
        {
            _cityDropdown.SelectDropdownOption(city);
        }
    }
}
