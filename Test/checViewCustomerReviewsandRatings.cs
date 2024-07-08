using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class CustomerReview : BaseClass
    {
        [Test]
        public void checViewCustomerReviewsandRatings()
        // View Customer Reviews and Ratings
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            bool s5 = driver.FindElement(By.XPath("//div[@class='row q4T7rk _8-rIO3']")).Displayed;
            Console.WriteLine(s5);
            string s1 = driver.FindElement(By.XPath("//div[contains(text(),'Awesome battery backup amazing camera, a all day b')]")).Text;
            Console.WriteLine(s1);

        }
    }
}

