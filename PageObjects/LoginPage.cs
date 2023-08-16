using OpenQA.Selenium;

namespace JobAdderAssignment.PageObjects
{
    public class LoginPage
    {
        IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Web Elements

        By Username = By.Id("user-name");

        By Password = By.Id("password");

        By LoginButton = By.Id("login-button");

        By ErrorMessage = By.XPath("//div[@class='error-message-container error']/h3");

        #endregion

        #region Methods

        public void LoginApplication(string myUsername, string myPassword)
        {
            driver.FindElement(Username).SendKeys(myUsername);
            driver.FindElement(Password).SendKeys(myPassword);
            driver.FindElement(LoginButton).Click();
        }

        public string GetErrorMessage()
        {
            return driver.FindElement(ErrorMessage).Text;
        }

        #endregion
    }
}
