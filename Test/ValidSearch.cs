using Flipkart.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flipkart.POM;
using NUnit.Framework.Legacy;

namespace Flipkart.Test
{
    [TestFixture]
    public class Search : BaseClass
    {
        private HomePage homePage;
        private ResultPage resultPage;


        [Test]
        public void VaildSearch1()
        {
            //Search for product---Valid Search

            homePage = new HomePage();
            resultPage = new ResultPage();
            homePage.ValidSearch();
            ClassicAssert.That(resultPage.AssetResult(), Is.EqualTo("Showing 1 – 24 of 741 results for \"iphone 13\""));
            //Thread.Sleep(7000);
            Console.WriteLine(resultPage.AssetResult());

        }
    }
}