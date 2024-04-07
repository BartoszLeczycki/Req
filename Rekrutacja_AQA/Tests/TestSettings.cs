using NUnit.Framework;
using OpenQA.Selenium;

namespace Rekrutacja_AQA.Tests
{
    [TestFixture]
    public sealed class TestSettings : Tests
    {
        private readonly IWebDriver driver;
        private readonly string url = @"https://www.forex.com/en-us/";

        [OneTimeSetUp]
        public void OneTimeSetUp()
        {
            driver = WebDriverHandler.Driver;
            driver.Manage().Window.Maximize();
        }

        [SetUp]
        public void SetupTest()
        {
            driver.Quit();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Navigate().GoToUrl(url);
        }
    }
}
