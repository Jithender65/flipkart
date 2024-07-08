using Flipkart.BaseClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;



namespace Flipkart.POM
{
    public class HomePage : BaseClass
    {
        [FindsBy(How = How.Name, Using = "q")]
        private IWebElement search;
        [FindsBy(How = How.XPath, Using = "//button[@title='Search for Products, Brands and More']//*[name()='svg']")]
        private IWebElement Submit;




        public HomePage()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }




        public void ValidSearch()
        {

            search.Clear();
            search.SendKeys("iphone 13");
            Submit.Click();
            //return search;

        }

    }
}