using OpenQA.Selenium;
using Rekrutacja_AQA.Tests;
using SeleniumExtras.WaitHelpers;

namespace Rekrutacja_AQA.Extensions
{
    public class ChromeDriverExtension
    {
        public void ScrollToElement(IWebDriver driver, IWebElement element, int offset)
        {
            // ?? 
        }

        public void SwitchToTheNewlyOpenedWindow(IWebDriver driver)
        {
            // ?? 
        }

        public void ClickWithWait(IWebDriver driver, By locator)
        {
            var wait = WebDriverHandler.Wait;
            var element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            element.Click();
        }
    }
}
