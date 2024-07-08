﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class checkproductAvailabilitybyLocation : BaseClass
    {
        [Test]
        public void checkproductAvailabilitybyLocation1()
        // check product Availability by Location 
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//button[normalize-space()='Enter Delivery Pincode']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@placeholder='Enter pincode']")).SendKeys("500089");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[@class='Ji2MFX']")).Click();
            Thread.Sleep(6000);
            string s2 = driver.FindElement(By.XPath("//div[@class='PEuQti']")).Text;
            Console.WriteLine(s2);

        }
    }
}