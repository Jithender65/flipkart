using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class DynamicReviewandRatingUpdates : BaseClass
    {

        [Test]
        public void DynamicReviewandRatingUpdates1()
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            String s1=driver.FindElement(By.XPath("//body/div[@id='container']/div/div[@class='_39kFie N3De93 JxFEK3 _48O0EI']/div[@class='DOjaWF YJG4Cf']/div[@class='DOjaWF gdgoEp col-8-12']/div[@class='DOjaWF gdgoEp']/div[@class='cPHDOP col-12-12']/div[@class='col pPAw9M']/div[@class='_8-rIO3']/div[1]/div[1]/div[1]")).Text;
            Console.WriteLine(s1);

        }
    }
}