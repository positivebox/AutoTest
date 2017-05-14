using System;
using Framework.Elements;

namespace UI.Pages.Vacancies
{
    public class VacancyCardSection
    {
        private int _cardIndex;
        private const string VacancyCardTitleXPathFormat = "//div[{0}]/a/div/h3[@class = 'card-vacancy_title']";
        private const string VacancyCardDirectionsXPathFormat = "//div[{0}]/a/div/div/dl[1]/dd";
        private const string VacancyCardCountryXPathFormat = "//div[{0}]/a/div/div/dl[2]/dd";
        private const string VacancyCardCityXPathFormat = "//div[{0}]/a/div/div/dl[3]/dd";

        internal VacancyCardSection(int cardIndex)
        {
            _cardIndex = cardIndex;
        }

        public string GetTitle()
        {
            return ElementFactory.InitializeElement(String.Format(VacancyCardTitleXPathFormat, _cardIndex))
                .GetInnerText();
        }

        public string GetDirections()
        {
            return ElementFactory.InitializeElement(String.Format(VacancyCardDirectionsXPathFormat, _cardIndex))
                .GetInnerText();
        }

        public string GetCountry()
        {
            return ElementFactory.InitializeElement(String.Format(VacancyCardCountryXPathFormat, _cardIndex))
                .GetInnerText();
        }

        public string GetCity()
        {
            return ElementFactory.InitializeElement(String.Format(VacancyCardCityXPathFormat, _cardIndex))
                .GetInnerText();
        }

        public void Open()
        {
            ElementFactory.InitializeElement(String.Format(VacancyCardTitleXPathFormat, _cardIndex))
                .Click();
        }
    }
}
