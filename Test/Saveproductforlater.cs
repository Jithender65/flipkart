﻿using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class Saveproduct : BaseClass
    {
        [Test]
        public void Saveproductforlater()
        // Save product for later
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//div[text()='Save for later']")).Click();
            Thread.Sleep(7000);

        }
    }
}