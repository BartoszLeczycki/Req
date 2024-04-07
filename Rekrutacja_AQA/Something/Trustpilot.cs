using OpenQA.Selenium;
using Rekrutacja_AQA.Extensions;
using Rekrutacja_AQA.Helpers;
using Rekrutacja_AQA.Tests;

namespace Rekrutacja_AQA.PageObjects
{
    public class Trustpilot
    {
        private readonly IWebDriver driver;

        public Trustpilot()
        {
            driver = WebDriverHandler.Driver;
        }

        private By ModalAcceptButtonLocator => By.XPath("//button[@id='onetrust-accept-btn-handler']");
        private IWebElement RatingMessage => driver.FindElement(By.XPath("//span[@class='typography_heading-m__T_L_X typography_appearance-default__AAY17']"));

        private string RatingMessageText => RatingMessage.Text;

        public Trustpilot AcceptTrustModal()
        {
            driver.SwitchToTheNewlyOpenedWindow();
            driver.ClickWithWait(ModalAcceptButtonLocator);
            return this;
        }

        public bool IsRatingCorrect(double expectedRating)
        {
            double actualRating = ParseHelper.ParseStringToDouble(RatingMessageText);
            return ParseHelper.AreDoublesEqual(actualRating, expectedRating, 0.0001);
        }
    }
}
