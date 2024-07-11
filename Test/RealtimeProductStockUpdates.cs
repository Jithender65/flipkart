using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class RealtimeProductStockUpdates : BaseClass
    {

        [Test]
        public void RealtimeProductStockUpdates1()
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            Thread.Sleep(7000);
            var s5 = driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Displayed;
            Console.WriteLine(s5);



        }
    }
}