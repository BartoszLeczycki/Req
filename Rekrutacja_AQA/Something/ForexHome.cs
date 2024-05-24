using OpenQA.Selenium;
using Rekrutacja_AQA.Extensions;
using Rekrutacja_AQA.Tests;

namespace Rekrutacja_AQA.PageObjects
{
    public class ForexHome
    {
        private readonly IWebDriver driver;

        public ForexHome()
        {
            driver = WebDriverHandler.Driver;
        }

        private IWebElement CelebratingCenturyImage => driver.FindElement(By.XPath("//img[@alt='Celebrating 100 Years of StoneX']"));
        private IWebElement CustomerReviewsIframe => driver.FindElement(By.XPath("//iframe[@title='Customer reviews powered by Trustpilot']"));
        private By ModalAcceptButtonLocator => By.XPath("//button[@id='onetrust-accept-btn-handler']");
        private By TrustpilotIconlocator => By.XPath("//a[@id='tp-widget-logo']");

        public Trustpilot GoToTrustpilotPage()
        {
            driver.ClickWithWait(ModalAcceptButtonLocator);
            Thread.Sleep(500);
            driver.ScrollToElement(CelebratingCenturyImage, -10);
            driver.SwitchTo().Frame(CustomerReviewsIframe);
            driver.ClickWithWait(TrustpilotIconlocator);
            driver.SwitchTo().DefaultContent();

            return this;
        }
    }
}
