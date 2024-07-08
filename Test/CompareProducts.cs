using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class Compare : BaseClass
    {

        [Test]
        public void CompareProduct()
        {
            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[2]/div[1]/div[1]/div[1]/a[1]/div[1]/div[2]/div[1]/span[1]/label[1]/div[1]")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[3]/div[1]/div[2]/div[4]/div[1]/div[1]/div[1]/a[1]/div[1]/div[2]/div[1]/span[1]/label[1]/div[1]")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//span[contains(text(),'COMPARE')]")).Click();
            Thread.Sleep(5000);
            Console.WriteLine(driver.Url);
         
        }

    }
}