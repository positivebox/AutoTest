using Framework;
using NUnit.Framework;
using UI;
using UI.Enums;

namespace Test
{
    public class Test1
    {
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
            PageManager.OpenVacanciesPage.SelectDirection("Software Development");
            PageManager.OpenVacanciesPage.SelectTechnology("C#");
            PageManager.OpenVacanciesPage.SelectCountry("Україна");
            PageManager.OpenVacanciesPage.SelectCity("Дніпро");
        }

        [TearDown]
        public void TestTearDown()
        {
            DriverManager.Quit();
        }
    }
}
