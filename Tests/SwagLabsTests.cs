using JobAdderAssignment.PageObjects;
using OpenQA.Selenium;

namespace JobAdderAssignment.Tests
{
    public class SwagLabsTests
    {
        IWebDriver driver;
        BrowserManager browserManager;
        LoginPage loginPage;
        ProductsPage productsPage;
        CartPage cartPage;

        [SetUp]
        public void SetupApplication()
        {
            browserManager = new BrowserManager();
            driver = browserManager.LaunchApplication();
            loginPage = new LoginPage(driver);
            productsPage = new ProductsPage(driver);
            cartPage = new CartPage(driver);
        }

        [Test, Order(1)]
        public void ValidateErrorMessage()
        {
            // Login to application with invalid credentials.
            loginPage.LoginApplication("TestUser123", "Test@123");

            // Verify error message.
            Assert.That(loginPage.GetErrorMessage(), Is.EqualTo("Epic sadface: Username and password do not match any user in this service"));
        }

        [Test, Order(2)]
        public void AddItemToCart()
        {
            // Login to application with valid credentials.
            loginPage.LoginApplication("standard_user", "secret_sauce");

            // Add any item to the cart.
            productsPage.AddItemToCart("Sauce Labs Backpack");
            productsPage.AddItemToCart("Sauce Labs Fleece Jacket");

            // Navigate to the cart by clicking on top right icon.
            productsPage.NavigateToShoppingCart();

            // Assert that the item is successfully added to cart.
            cartPage.VerifyAddedItemsToCart("Sauce Labs Backpack", "Sauce Labs Fleece Jacket");
        }

        [TearDown]
        public void CloseApplication()
        {
            browserManager.CloseApplication();
        }
    }
}