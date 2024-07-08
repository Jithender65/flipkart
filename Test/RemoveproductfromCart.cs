using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;
using Flipkart.POM;
using NUnit.Framework.Legacy;

namespace flipkart
{
    [TestFixture]
    public class RemoveproductfromCart : BaseClass
    {
        private HomePage homePage;
        private ResultPage resultPage;
        private ProductPage productPage;
        private CartPage cartPage;
        [Test]
        public void ViewCarRemoveproductfromCart()
        // Remove product from  Cart
        {
            homePage = new HomePage();
            homePage.ValidSearch();
            resultPage = new ResultPage();
            resultPage.RemoveCart();
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            Thread.Sleep(3000);
            productPage = new ProductPage();
            productPage.RemoveCart();
            Thread.Sleep(3000);
            cartPage = new CartPage();
            cartPage.Removeproduct();
            Thread.Sleep(3000);
            ClassicAssert.That(cartPage.Removeproduct1(),Is.EqualTo("Missing Cart items?"));
            Console.WriteLine(cartPage.Removeproduct1());
              
        }
    }
}

