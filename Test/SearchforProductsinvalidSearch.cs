using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class InvalidSearch : BaseClass
    {

        [Test]
        public void SearchforProductsinvalidSearch()
        // Search for Products-----invalid Search
        {
            driver.FindElement(By.Name("q")).SendKeys("hybgdr");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
            Console.WriteLine(driver.Url);
            String s1 = driver.FindElement(By.XPath("//div[text()='Sorry, no results found!']")).Text;
            Console.WriteLine(s1);
        }
    }
}