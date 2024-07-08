using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class DynamicSearch : BaseClass
    {




        [Test]
        public void DynamicSearchSuggestions()
        {
            //Dynamic Search Suggetsions

            //LoginPage loginPage = new LoginPage(getDriver());
            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
            string s1 = driver.FindElement(By.XPath("//span[@class='BUOuZu']")).Text;
            Console.WriteLine(s1);
            bool isdisplayed = driver.FindElement(By.XPath("//span[text()='iphone 13']")).Displayed;
            Console.WriteLine(isdisplayed);
            Thread.Sleep(7000);


        }
    }
}