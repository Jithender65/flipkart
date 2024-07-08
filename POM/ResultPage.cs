using Flipkart.BaseClasses;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using Flipkart.Test;
using OpenQA.Selenium.Support.UI;



namespace Flipkart.POM
{
    public class ResultPage : BaseClass
    {
        [FindsBy(How = How.XPath, Using = "//span[@class='BUOuZu']")]  //Showing 1 – 24 of 741 results for \"iphone 13\
        private IWebElement Result;

          [FindsBy(How = How.XPath, Using = "//div[@class='suthUA']//select[@class='Gn+jFg']")] //PRICE  Range 1
        private IWebElement Result1;
        [FindsBy(How = How.XPath, Using = "//div[@class='tKgS7w']//select[@class='Gn+jFg']")] //PRICE  Range 2
        private IWebElement Result2;
        [FindsBy(How = How.XPath, Using = "//div[@class='_6i1qKy'][normalize-space()='Apple']")] //Brand
        private IWebElement Result3;
         [FindsBy(How = How.XPath, Using = "//div[@title='3★ & above']//div[@class='XqNaEv']")] //Rating 
       private IWebElement Result4;
        [FindsBy(How = How.XPath, Using = "//span[normalize-space()='iphone 13']")] //text iphone 13
        private IWebElement Result5;
        [FindsBy(How = How.XPath, Using = "//div[text()='Price -- Low to High']")] //price ---low to high 
        private IWebElement Result6;
        [FindsBy(How = How.XPath, Using = " //div[text()='Apple iPhone 13 (Pink, 128 GB)']")]   //iphone 13 pink 128gb
        private IWebElement Result7;


       

        public ResultPage()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }
        //1.Valid Search
        public string AssetResult()
        {
             return Result.Text;
             

        }
        //2.Valid Filters
        public void ValidFilters()
        {
            Result1.Click();
            SelectElement selectElement = new SelectElement(Result1);
            selectElement.SelectByValue("30000");
            SelectElement selectElement1 = new SelectElement(Result2);
            selectElement1.SelectByValue("Max"); 
            Thread.Sleep(4000);
            Result3.Click();
            Thread.Sleep(4000);
            Result4.Click();
        }
        public string AssetResult1()
        {

            return Result5.Text;

        }
        // 3.valid sorting 
        public void ValidSorting()
        {
            Result1.Click();
            SelectElement selectElement = new SelectElement(Result1);
            selectElement.SelectByValue("30000");
            SelectElement selectElement1 = new SelectElement(Result2);
            selectElement1.SelectByValue("Max");
            Thread.Sleep(4000);
            Result3.Click();
            Thread.Sleep(4000);
            Result4.Click();
            Thread.Sleep(4000);
            Result6.Click();
            Thread.Sleep(4000);
        }
        //4.view productdetails
        public void Viewproductdetails()
        {
            
            Result7.Click();

        }
        // 5 Add product to the cart.
        public void AddProductToCart()
        {

            Result7.Click();

        }
        // 6 view Cart
        public void ViewCart()
        {

            Result7.Click();

        }
        // 7.Remove product from  Cart
        public void RemoveCart()
        {

            Result7.Click();

        }





    }
}
