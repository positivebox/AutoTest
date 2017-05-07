using UI.Common;

namespace UI.Pages.Vacancies
{
    public class OpenVacanciesPage : BasePage
    {
        private Dropdown _directionDropdown = new Dropdown("direction");
        private Dropdown _technologyDropdown = new Dropdown("lang");
        private Dropdown _countryDropdown = new Dropdown("country");
        private Dropdown _cityDropdown = new Dropdown("city");

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
