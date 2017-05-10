using System;
using Framework.Elements;
using UI.Common;

namespace UI.Pages.Benefits
{
    public class BenefitsPage : BasePage
    {
        private const string BenefitTitleXpathFormat = "//*[@class='media-benefit_title' and contains(text(),'{0}')]";

        private Dropdown _countryDropdown = new Dropdown("country");
        private Dropdown _cityDropdown = new Dropdown("city");
        private Element _benefitTitle;

        internal BenefitsPage()
        {
            Url = "https://softserve.ua/ua/benefits/our-benefits/";
        }

        public void SelectCountry(string country)
        {
            _countryDropdown.SelectDropdownOption(country);
        }

        public void SelectCity(string city)
        {
            _countryDropdown.SelectDropdownOption(city);
        }

        public void SelectBenefit(string title)
        {
            _benefitTitle = ElementFactory
                .InitializeElement(String.Format(BenefitTitleXpathFormat, title));
            _benefitTitle.Click();
        }
    }
}
