using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;
using Flipkart.POM;

namespace flipkart
{
    [TestFixture]
    public class Add : BaseClass
    {

        private HomePage homePage;
        private ResultPage resultPage;
        private ProductPage productPage;




        [Test]
        public void AddProductToCart()
        // Add product to the cart.
        {
            homePage = new HomePage();
            homePage.ValidSearch();
            resultPage = new ResultPage();
            resultPage.AddProductToCart();
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            Thread.Sleep(3000);
            productPage = new ProductPage();
            productPage.AddProductToCart();
            Thread.Sleep(3000);
            Console.WriteLine(driver.Url);
            

        }
    }
}