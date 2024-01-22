using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace QALight_Task_7
{
    public class TestBase
    {
        protected static ChromeDriver _driver = new ChromeDriver();

        [SetUp]
        public void SetUp()
        {
            _driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        }

        [TearDown]
        public void TearDown()
        {

        }

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            _driver.Manage().Window.Maximize();
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {
            _driver.Quit();
        }
    }
}
