using OpenQA.Selenium;

namespace JobAdderAssignment.PageObjects
{
    public class ProductsPage
    {
        IWebDriver driver;

        public ProductsPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Web Elements

        By ShoppingCart = By.XPath("//a[@class='shopping_cart_link']");

        #endregion

        #region Methods

        public void AddItemToCart(string productName)
        {
            var product = driver.FindElement(By.XPath($"//div[@class='inventory_item_name'][contains(text(), '{productName}')]/../../following-sibling::div//button"));
            product.Click();
        }

        public void NavigateToShoppingCart()
        {
            driver.FindElement(ShoppingCart).Click();
        }

        #endregion
    }

}
