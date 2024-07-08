using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class Categories : BaseClass
    {
        [Test]
        public void BrowseCategories()
        // Browse Categories
        {
            driver.FindElement(By.XPath("//span[@class='_1XjE3T']//span[text()='Electronics']")).Click();
            driver.FindElement(By.XPath("//a[@class='_1BJVlg _11MZbx']")).Click();
            Console.WriteLine(driver.Title);
            Thread.Sleep(5000);
        } } }
        
