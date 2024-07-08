using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;
using Flipkart.POM;
using NUnit.Framework.Legacy;

namespace flipkart.Test
{
    [TestFixture]
    public class Filter : BaseClass
    {
        private HomePage homePage;
        private ResultPage resultPage;


        [Test]
        public void ValidFilters()

        //Apply Filters on Search Results---Valid Filters
        {

            homePage = new HomePage();
            resultPage = new ResultPage();
            homePage.ValidSearch();
            resultPage.ValidFilters();
            Thread.Sleep(6000);
            ClassicAssert.That(resultPage.AssetResult1(), Is.EqualTo("iphone 13"));
            Console.WriteLine(resultPage.AssetResult1());



        }
    }
}         