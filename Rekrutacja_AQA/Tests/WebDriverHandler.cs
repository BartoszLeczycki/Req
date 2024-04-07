using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Rekrutacja_AQA.Tests
{
    public class WebDriverHandler
    {
        private static WebDriverHandler instance;
        public IWebDriver driver;
        public WebDriverWait wait;

        public WebDriverHandler()
        {
            driver = new ChromeDriver();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        public static WebDriverHandler Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new WebDriverHandler();
                }
                return instance;
            }
        }

        private static IWebDriver Driver
        {
            get { return Instance.driver; }
        }

        private static WebDriverWait Wait
        {
            get { return Instance.wait; }
        }
    }
}
