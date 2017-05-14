using System;
using Framework.Driver;
using NUnit.Framework;
using UI;
using UI.Enums;
using Framework;

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
            try {
                PageManager.HomePage.MainMenu.NavigateViaMenu(MainMenuOptions.Vacancies, 1);
                PageManager.OpenVacanciesPage.DirectionDropdown.SelectDropdownOption(_testDirection);
                PageManager.OpenVacanciesPage.TechnologyDropdown.SelectDropdownOption(_testTechnology);
                PageManager.OpenVacanciesPage.CountryDropdown.SelectDropdownOption(_testCountry);
                PageManager.OpenVacanciesPage.CityDropdown.SelectDropdownOption(_testCity);

                Assert.True(PageManager.OpenVacanciesPage.VacancyCards.Count == 1);
                Assert.AreEqual(PageManager.OpenVacanciesPage.VacancyCards[0].GetTitle(), "SiteCore CMS Engineer");
                Assert.AreEqual(PageManager.OpenVacanciesPage.VacancyCards[0].GetDirections(), String.Format(".NET, {0}, {1}", _testTechnology, _testDirection));
                Assert.AreEqual(PageManager.OpenVacanciesPage.VacancyCards[0].GetCountry(), _testCountry);
                Assert.AreEqual(PageManager.OpenVacanciesPage.VacancyCards[0].GetCity(), _testCity);

                PageManager.OpenVacanciesPage.VacancyCards[0].Open();

                Assert.AreEqual(PageManager.VacancyPage.GetTitle(), "SiteCore CMS Engineer");
                Assert.AreEqual(PageManager.VacancyPage.GetDirections(), String.Format(".NET, {0}, {1}", _testTechnology, _testDirection));
                Assert.AreEqual(PageManager.VacancyPage.GetCountry(), _testCountry);
                Assert.AreEqual(PageManager.VacancyPage.GetCity(), _testCity);

                PageManager.VacancyPage.OpenApplyCvSection();
                PageManager.VacancyPage.ApplyCVSection.EmailField.SendKeys("someemail@@mailinator.com");
                PageManager.VacancyPage.ApplyCVSection.WhereFromDropdown.SelectDropdownOption("Other");
                PageManager.VacancyPage.ApplyCVSection.SubmitCv();

                Logger.Info("Test succesfully passed");
            }
            catch (Exception ex)
            {
                Logger.Error(ex.Message);
            }
            }

        [TearDown]
        public void TestTearDown()
        {
            DriverManager.Driver.Quit();
        }
    }
}
