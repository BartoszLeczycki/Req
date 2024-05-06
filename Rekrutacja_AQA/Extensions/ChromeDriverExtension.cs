using OpenQA.Selenium;
using Rekrutacja_AQA.Tests;
using SeleniumExtras.WaitHelpers;

namespace Rekrutacja_AQA.Extensions
{
    public class ChromeDriverExtension
    {
        public void ScrollToElement(IWebDriver driver, IWebElement element, int offset)
        {
            ((IJavaScriptExecutor)driver).ExecuteScript(
                "arguments[0].scrollIntoView(true); window.scrollBy(0, arguments[1]);",
                element, offset);
        }

        public void SwitchToTheNewlyOpenedWindow(IWebDriver driver)
        {
            driver.SwitchTo().Window(driver.WindowHandles.First());
        }

        public void ClickWithWait(IWebDriver driver, By locator)
        {
            var wait = WebDriverHandler.Wait;
            var element = wait.Until(ExpectedConditions.ElementToBeClickable(locator));
            element.Click();
        }
    }
}
