using Framework;
using System;

namespace UI.Pages
{
    public class BenefitsPage : BasePage
    {
        private const string CountryOptionXpathFormat = @"//select[@id=""tax-country""]/option[contains(text(),'{0}')]";
        private const string CityOptionXpathFormat = @"//select[@id=""tax-city""]/option[contains(text(),'{0}')]";
        private const string BenefitTitleXpathFormat = @"//*[@class=""media-benefit_title"" and contains(text(),'{0}')]";

        private Element CountryDropdown { get { return CountryDropdown
                    .ElementFactory(@"//*[@id=""s2id_tax-country""]/a"); } }
        private Element CityDropdown { get { return CityDropdown
                    .ElementFactory(@"//*[@id=""s2id_tax-city""]/a"); } }

        private Element CountryOption { get; }
        private Element CityOption { get; }
        private Element BenefitTitle { get; }



        public BenefitsPage()
        {
            Url = "https://softserve.ua/ua/contacts/";
        }

        public void SelectCountry(string country)
        {
            CountryDropdown.Click();
            CountryOption.ElementFactory(String.Format(CountryOptionXpathFormat, country));
            CountryOption.Click();
        }

        public void SelectCity(string city)
        {
            CityDropdown.Click();
            CityOption.ElementFactory(String.Format(CityOptionXpathFormat, city));
            CityOption.Click();
        }

        public void SelectBenefit(string title)
        {
            BenefitTitle.ElementFactory(String.Format(BenefitTitleXpathFormat, title));
            BenefitTitle.Click();
        }
    }
}
