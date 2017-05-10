using System;
using Framework.Driver;
using NUnit.Framework;
using UI;
using UI.Enums;

namespace Test
{
    public class Test1
    {
        private string _testDirection = "Software Development";
        private string _testTechnology = "C#";
        private string _testCountry = "Україна";
        private string _testCity = "Дніпро";

        [SetUp]
        public void TestSetUp()
        {
            DriverManager.SelectDriver(Browser.Chrome);
            PageManager.HomePage.OpenPage();
        }

        [Test]
        public void Test()
        {
            PageManager.HomePage.MainMenu.NavigateViaMenu(MainMenuOptions.Vacancies, 1);
            PageManager.OpenVacanciesPage.SelectDirection(_testDirection);
            PageManager.OpenVacanciesPage.SelectTechnology(_testTechnology);
            PageManager.OpenVacanciesPage.SelectCountry(_testCountry);
            PageManager.OpenVacanciesPage.SelectCity(_testCity);

            Assert.True(PageManager.OpenVacanciesPage.VacancyCards.Count == 1);
            Assert.AreEqual(PageManager.OpenVacanciesPage.VacancyCards[0].GetTitle(), "SiteCore CMS Engineer");
            Assert.AreEqual(PageManager.OpenVacanciesPage.VacancyCards[0].GetDirections(), String.Format(".NET, {0}, {1}", _testTechnology, _testDirection));
            Assert.AreEqual(PageManager.OpenVacanciesPage.VacancyCards[0].GetCountry(), _testCountry);
            Assert.AreEqual(PageManager.OpenVacanciesPage.VacancyCards[0].GetCity(), _testCity);
        }

        [TearDown]
        public void TestTearDown()
        {
            DriverManager.Driver.Quit();
        }
    }
}
