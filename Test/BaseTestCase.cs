using NUnit.Framework;
using Framework;

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
            DriverManager.Quit();
        }
    }
}
