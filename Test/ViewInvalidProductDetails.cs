using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class InvalidProduct : BaseClass
    {
        [Test]
        public void ViewProductDetailsInvalidProduct()
        {
            driver.FindElement(By.Name("q")).SendKeys("dolo tablets");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@class='Ek4lpE']")).Click();
            Thread.Sleep(3000);
            bool s5 = driver.FindElement(By.XPath("//div[text()='Sorry, no results found!']")).Displayed;
            Console.WriteLine(s5);
            

        }
    }
}