using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class DynamicCustomerSupportChat : BaseClass
    {
        [Test]
        public void DynamicCustomerSupportChat1()
        // Help
        {
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//a[@title='Dropdown with more help links']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//li[normalize-space()='24x7 Customer Care']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//div[@class='Pg+ADy eJKPU5']//div[4]")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//span[normalize-space()='Account Related Queries']")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.XPath("//div[normalize-space()='I want to create my Flipkart account']")).Click();
            Thread.Sleep(3000);
            String S= driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]")).Text;
            Console.WriteLine(S);
            Thread.Sleep(3000);
        }
    }
}