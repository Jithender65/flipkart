using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class Offers : BaseClass
    {


        [Test]
        public void CheckOffersandDiscounts()
        // Check Offers and Discounts
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            bool s5 = driver.FindElement(By.XPath("//div[@class='I+EQVr']")).Displayed;
            Console.WriteLine(s5);
            String s4 = driver.FindElement(By.XPath("//div[@class='I+EQVr']")).Text;
            Console.WriteLine(s4);
            String s1 = driver.FindElement(By.XPath("//div[@class='hl05eU']")).Text;
            Console.WriteLine(s1);
            Thread.Sleep(5000);
        }
    }
}

    
