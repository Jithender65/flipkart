using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class ProductImages : BaseClass
    {
        [Test]
        public void ViewProductImages()
        // View Product Images
        {

            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            driver.FindElement(By.XPath("//div[@class='HXf4Qp SibU2y']//img[@class='_0DkuPH']")).Click();
            Thread.Sleep(6000);
            bool s5 = driver.FindElement(By.XPath("//img[@class='DByuf4 IZexXJ jLEJ7H']")).Displayed;
            Console.WriteLine(s5);
        }
    }
}
