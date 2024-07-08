using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class DynamicOfferApplcation : BaseClass
    {
        [Test]
        public void DynamicOfferApplcation1()
        // Add product to the cart.
        {
            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            String s = driver.FindElement(By.XPath("//label[@for='BUY_WITHOUT_EXCHANGE']")).Text;
            Console.WriteLine(s);
            String s1 = driver.FindElement(By.XPath("//label[@for='BUY_WITH_EXCHANGE']")).Text;
            Console.WriteLine(s1);  
        }
    }
}