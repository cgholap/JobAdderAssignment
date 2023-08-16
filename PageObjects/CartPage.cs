using OpenQA.Selenium;

namespace JobAdderAssignment.PageObjects
{
    public class CartPage
    {
        IWebDriver driver;

        public CartPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        #region Methods

        public void VerifyAddedItemsToCart(params string[] products)
        {
            foreach (string product in products)
            {
                var productName = driver.FindElement(By.XPath($"//div[@class='inventory_item_name'][text() = '{product}']"));
                Assert.IsTrue(productName.Displayed);
            }
        }

        #endregion
    }
}