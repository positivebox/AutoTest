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
            PageManager.HomePage.MainMenu.NavigateViaMenu(MainMenuOptions.Company, 1);
        }

        [TearDown]
        public void TestTearDown()
        {
        }
    }
}
