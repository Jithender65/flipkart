using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class InvalidPINCode : BaseClass
    {
        [Test]
        public void CheckProductAvailabilityInvalidPINCode()
        // 20.	Check Product Availability - Invalid PIN Code
        {
            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            driver.FindElement(By.XPath("//input[@class='AFOXgu']")).SendKeys("12345");
            
            driver.FindElement(By.XPath("//span[@class='i40dM4']")).Click();
            
            string s1 = driver.FindElement(By.XPath("//div[@class='nyRpc8']")).Text;
            Console.WriteLine(s1);
        }
    }
}