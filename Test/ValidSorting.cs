using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;
using Flipkart.POM;

namespace flipkart
{
    [TestFixture]
    public class Sorting : BaseClass
    {
        private HomePage homePage;
        private ResultPage resultPage;

        [Test]
        public void ValidSorting()

        //Sort Search Results---Valid Sorting
        {
            homePage = new HomePage();
            resultPage = new ResultPage();
            homePage.ValidSearch();
            resultPage.ValidSorting();
            Thread.Sleep(8000);


        }
    }
}