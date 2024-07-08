using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class InvalidFilters : BaseClass
    {
        [Test]
        public void ApplyFiltersonSearchResultsInvalidFilters()
        // Apply Filters on Search Results----Invalid Filters
        {
            driver.FindElement(By.Name("q")).SendKeys("iphone");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
            IWebElement Element = driver.FindElement(By.XPath("//div[@class='suthUA']//select[@class='Gn+jFg']"));
            SelectElement selectElement = new SelectElement(Element);
            selectElement.SelectByValue("Min");

            IWebElement Element1 = driver.FindElement(By.XPath("//div[@class='tKgS7w']//select[@class='Gn+jFg']"));

            SelectElement selectElement1 = new SelectElement(Element1);
            Thread.Sleep(10000);
            selectElement1.SelectByValue("20000"); //To Verify dropdown is working or not 
            Thread.Sleep(10000);
            selectElement1.SelectByValue("10000");
            Thread.Sleep(5000);
            String s1 = driver.FindElement(By.XPath("//div[text()='Sorry, no results found!']")).Text;
            Console.WriteLine(s1);
        }
    }
}
