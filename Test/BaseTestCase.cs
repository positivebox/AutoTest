using NUnit.Framework;
using Framework.Driver;

namespace Test
{
    public abstract class BaseTestcase
    {
        [SetUp]
        public void TestSetUp()
        {
        }

        [TearDown]
        public void TestTearDown()
        {
            DriverManager.Driver.Quit();
        }
    }
}
