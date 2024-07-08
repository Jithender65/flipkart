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
    public class CartPage : BaseClass
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='kQCHPX']")] //PRICE DETAILS in cart page 
        private IWebElement Result;
        [FindsBy(How = How.XPath, Using = "//a[text()='Apple iPhone 13 (Pink, 128 GB)']")] //iphone 13 (Pink, 128 GB) in cart page
        private IWebElement Result1;
        [FindsBy(How = How.XPath, Using = "//div[text()='Remove']")] //product remove 
        private IWebElement Result2;
        [FindsBy(How = How.XPath, Using = "//div[@class='sBxzFz fF30ZI A0MXnh']")] //product remove after popup
        private IWebElement Result3;
        [FindsBy(How = How.XPath, Using = "//div[@class='s2gOFd']")] //Missing Cart items?
        private IWebElement Result4;

        

        //div[text()='Remove']
        public CartPage()
        {
            //this.driver = driver;
            PageFactory.InitElements(driver, this);

        }


        // 6.view Cart

        public bool ViewCart()
        {
            return Result.Displayed;
        }
        public bool ViewCart1()
        {
            return Result1.Displayed;
        }

         //7. Remove product from  Cart
        
        public void Removeproduct()
        {
           Result2.Click();
            Result3.Click();
        }

        public string Removeproduct1()
        {
            return Result4.Text;

        }
    }
}
