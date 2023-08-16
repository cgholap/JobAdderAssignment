using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace JobAdderAssignment
{
    public class BrowserManager
    {
        public IWebDriver driver { get; set; }

        public IWebDriver LaunchApplication()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.saucedemo.com/";
            return driver;
        }

        public void CloseApplication()
        {
            driver.Close();
        }
    }
}
