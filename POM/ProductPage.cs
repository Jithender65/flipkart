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
    public class ProductPage : BaseClass
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='Nx9bqj CxhGGd']")] //₹52,999
        private IWebElement Result1;
        [FindsBy(How = How.XPath, Using = "//div[@class='Xbd0Sd']")] //description
        private IWebElement Result2;
        [FindsBy(How = How.XPath, Using = "//button[@class='QqFHMw vslbG+ In9uk2']")]//cart click 
        private IWebElement Result3;

        public ProductPage()
        {
            PageFactory.InitElements(driver, this);

        }
        //4.view productdetails
        public string Viewproductdetails()
        {
            return Result1.Text;
           
        }
        public bool Viewproductdetails1()
        {
            
            return Result2.Displayed;
        }

        // 5. Add product to the cart.
        public void AddProductToCart()
        {

            Result3.Click();
        }

        // 6.view Cart
        public void ViewCart()
        {

            Result3.Click();
        }
        // 7.Remove product from  Cart
        public void RemoveCart()
        {

            Result3.Click();
        }

    }
}