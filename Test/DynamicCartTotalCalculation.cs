using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class DynamicCartTotalCalculation : BaseClass
    {

        [Test]
        public void DynamicCartTotalCalculation1()
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
             Thread.Sleep(7000);
            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            Thread.Sleep(7000);
            //string ChildWindowName1 = driver.WindowHandles[2];
            //driver.SwitchTo().Window(ChildWindowName1);
            driver.FindElement(By.XPath("//button[@type='submit']//*[name()='svg']")).Submit();
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Starlight, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName1 = driver.WindowHandles[2];
            driver.SwitchTo().Window(ChildWindowName1);
            driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
            Thread.Sleep(7000);

        }
        
        
    }
}