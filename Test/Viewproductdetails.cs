using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;
using Flipkart.POM;
using NUnit.Framework.Legacy;
using static Microsoft.ApplicationInsights.MetricDimensionNames.TelemetryContext;

namespace flipkart
{
    [TestFixture]
    public class Productdetails : BaseClass
    {

        private HomePage homePage;
        private ResultPage resultPage;
        private ProductPage productPage;

        [Test]
        public void viewproductdetails()

        //view product details
        {

            homePage = new HomePage();
            homePage.ValidSearch();
            resultPage = new ResultPage();
            resultPage.Viewproductdetails();
            Thread.Sleep(2000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            Thread.Sleep(1000);
            productPage = new ProductPage();
             productPage.Viewproductdetails();
            productPage.Viewproductdetails1();
            ClassicAssert.That(productPage.Viewproductdetails(), Is.EqualTo("₹52,999"));
            Console.WriteLine(productPage.Viewproductdetails());
            Thread.Sleep(1000);
            ClassicAssert.IsTrue(productPage.Viewproductdetails1());
            Console.WriteLine(productPage.Viewproductdetails1());
            Thread.Sleep(1000);

           
            


        }
    }
}