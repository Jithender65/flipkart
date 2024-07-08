using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class DynamicReviewFilteringandSortingFilter : BaseClass
    {

        [Test]
        public void DynamicReviewFilteringandSortingFilter1()

        //Apply Filters on Search Results---Valid Filters
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
            IWebElement Element = driver.FindElement(By.XPath("//div[@class='suthUA']//select[@class='Gn+jFg']"));
            driver.FindElement(By.XPath("//div[@class='_6i1qKy'][normalize-space()='Apple']")).Click();
            Thread.Sleep(6000);
            driver.FindElement(By.XPath("//div[@title='3★ & above']//div[@class='QCKZip hpLdC3']//div[1]")).Click();
            Thread.Sleep(7000);
            String s1 = driver.FindElement(By.XPath("//span[@class='BUOuZu']")).Text;
            Console.WriteLine(s1);
        }
    }
}
