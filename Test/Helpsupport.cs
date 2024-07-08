using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class HelpSupport : BaseClass
    {
        [Test]
        public void Helpsupport()
        // Help
        {
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//a[@title='Dropdown with more help links']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//li[normalize-space()='24x7 Customer Care']")).Click();
            Thread.Sleep(4000);
            Console.WriteLine(driver.Url);
        }
    }
}