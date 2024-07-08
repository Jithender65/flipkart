using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class DynamicBundleOffersandDiscounts : BaseClass
    {
        [Test]
        public void DynamicBundleOffersandDiscounts1()
        // Add product to the cart.
        {
            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
            Thread.Sleep(3000);
            String s1 = driver.FindElement(By.XPath("//div[@class='_3j-e05']")).Text;
            Console.WriteLine(s1);

        }
    }
}