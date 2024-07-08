using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;
using Flipkart.POM;
using NUnit.Framework.Legacy;

namespace flipkart
{
    [TestFixture]
    public class Cart : BaseClass
    {

        private HomePage homePage;
        private ResultPage resultPage;
        private ProductPage productPage;
        private CartPage cartPage;

        [Test]
        public void ViewCart()
        // view Cart
        {
            homePage = new HomePage();
            homePage.ValidSearch();
            resultPage = new ResultPage();
            resultPage.ViewCart();
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            Thread.Sleep(3000);
            productPage = new ProductPage();
            productPage.ViewCart();
            Thread.Sleep(6000);
            cartPage = new CartPage();
            ClassicAssert.IsTrue(cartPage.ViewCart());
            Console.WriteLine(cartPage.ViewCart());
            ClassicAssert.IsTrue(cartPage.ViewCart1());
            Console.WriteLine(cartPage.ViewCart1());
            Thread.Sleep(1000);
        }
    }
}