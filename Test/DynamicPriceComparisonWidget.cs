using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using Flipkart.BaseClasses;

namespace flipkart
{
    [TestFixture]
    public class DynamicPriceComparisonWidget : BaseClass
    {
        [Test]
        public void DynamicPriceComparisonWidget1()

        //view product details
        {

            driver.FindElement(By.Name("q")).SendKeys("daikin 2023 model 1.5 ton 3 star");
            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
            driver.FindElement(By.XPath("//body/div[@id='container']/div/div[@class='nt6sNV JxFEK3 _48O0EI']/div[@class='DOjaWF YJG4Cf']/div[@class='DOjaWF gdgoEp']/div[@class='cPHDOP col-12-12']/div[@class='_75nlfW']/div[@data-id='ACNGFSYTSYRUQUSZ']/div[@class='tUxRFH']/a[@class='CGtC98']/div[@class='yKfJKb row']/div[@class='col col-7-12']/div[1]")).Click();
            Thread.Sleep(7000);
            string ChildWindowName = driver.WindowHandles[1];
            driver.SwitchTo().Window(ChildWindowName);
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//div[@class='eJnmek']")).Click();
            Thread.Sleep(4000);
            String S1 = driver.FindElement(By.XPath("//span[normalize-space()='OmniTechRetail']")).Text;
            Console.WriteLine(S1);
            Thread.Sleep(4000);
            String S2 = driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/div[3]/div[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[1]/div[1]/div[1]")).Text;
            Console.WriteLine(S2);
            Thread.Sleep(4000);
            String S3 = driver.FindElement(By.XPath("//span[normalize-space()='CallForCool']")).Text;
            Console.WriteLine(S3);
            Thread.Sleep(4000);
            String S4 = driver.FindElement(By.XPath("//body/div[@id='container']/div/div[@class='arV-9z']/div[@class='XW26V9']/div[@class='Pg+ADy']/div[@class='Brc9kn']/div[@class='_1jhEEq']/div[@class='_327ECm']/div[2]/div[2]/div[1]")).Text;
            Console.WriteLine(S4);
            Thread.Sleep(4000);

        }
    }
}