using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;
using NUnit.Framework.Legacy;

namespace flipkart
{
    [TestFixture]
    public class OutofStock : BaseClass
    {
        [Test]
        public void ADDoutofstockProducttoCart()
        // ADD out of stock Product to Cart
        {
            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            driver.FindElement(By.XPath("//input[@class='AFOXgu']")).SendKeys("190001");
            Thread.Sleep(7000);
            driver.FindElement(By.XPath("//span[@class='i40dM4']")).Click();
            Thread.Sleep(7000);
            bool s5 = driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2 _7dtcvJ']")).Enabled;
            //Console.WriteLine(s5);
            ClassicAssert.False(s5);
            
        }
    }
}