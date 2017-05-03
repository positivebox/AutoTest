using Framework;
using NUnit.Framework;
using UI.Enums;
using UI.Pages;

namespace Test
{
    public class Test1
    {
        [SetUp]
        public void TestSetUp()
        {
            DriverManager.SelectDriver(Driver.ChromeDriver);
            Pages.HomePage.OpenPage();
        }

        [Test]
        public void Test()
        {
            Pages.HomePage.MainMenu.NavigateViaMenu(MainMenuOptions.Company, 1);
        }

        [TearDown]
        public void TestTearDown()
        {
        }
    }
}
