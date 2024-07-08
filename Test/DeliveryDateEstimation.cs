using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class Estimation : BaseClass
    {

        [Test]
        public void DeliveryDateEstimation()
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            driver.FindElement(By.XPath("//input[@id='pincodeInputId']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//input[@id='pincodeInputId']")).SendKeys("500089");
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//span[@class='i40dM4']")).Click();
            Thread.Sleep(6000);
            string s2 = driver.FindElement(By.XPath("//div[@class='hVvnXm']")).Text;
            Console.WriteLine(s2);
            string s3 = driver.FindElement(By.XPath("//div[@class='m-cM89']")).Text;
            Console.WriteLine(s3);

        }
    }
}
