//using flipkart.Utilities;
//using OpenQA.Selenium.Chrome;
//using OpenQA.Selenium;
//using OpenQA.Selenium.Support.UI;

//namespace flipkart
//{
//    [TestFixture]
//    public class Tests : BaseClass
//    {




////        //[Test]
////        //public void vaildSearch()
////        //{
////        //    //Search for product---Valid Search

////        //    //LoginPage loginPage = new LoginPage(getDriver());
////        //        driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //        driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
////        //        string s1 = driver.FindElement(By.XPath("//span[@class='BUOuZu']")).Text;
////        //        Console.WriteLine(s1);
////        //        bool isdisplayed = driver.FindElement(By.XPath("//span[text()='iphone 13']")).Displayed;
////        //        Console.WriteLine(isdisplayed);
////        //        Thread.Sleep(7000);


////        //}

////        //[Test]
////        //public void ValidFilters()

////        ////Apply Filters on Search Results---Valid Filters
////        //{

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
////        //    IWebElement Element = driver.FindElement(By.XPath("//div[@class='suthUA']//select[@class='Gn+jFg']"));
////        //    SelectElement selectElement = new SelectElement(Element);
////        //    selectElement.SelectByValue("30000");
////        //    Thread.Sleep(3000);
////        //    IWebElement Element1 = driver.FindElement(By.XPath("//div[@class='tKgS7w']//select[@class='Gn+jFg']"));
////        //    SelectElement selectElement1 = new SelectElement(Element1);
////        //    selectElement1.SelectByValue("Max");
////        //    driver.FindElement(By.XPath("//div[@class='_6i1qKy'][normalize-space()='Apple']")).Click();
////        //    driver.FindElement(By.XPath("//div[@title='3★ & above']//div[@class='QCKZip hpLdC3']//div[1]")).Click();
////        //    string s2 = driver.FindElement(By.XPath("//span[@class='BUOuZu']")).Text;
////        //    Console.WriteLine(s2);
////        //    Thread.Sleep(7000);
////        //    

////        //}


////        //[Test]
////        //public void ValidSorting()

////        ////Sort Search Results---Valid Sorting
////        //{      

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //   driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
////        //    IWebElement Element = driver.FindElement(By.XPath("//div[@class='suthUA']//select[@class='Gn+jFg']"));
////        //        SelectElement selectElement = new SelectElement(Element);
////        //        selectElement.SelectByValue("30000");

////        //       IWebElement Element1 = driver.FindElement(By.XPath("//div[@class='tKgS7w']//select[@class='Gn+jFg']"));
////        //    SelectElement selectElement1 = new SelectElement(Element1);
////        //    selectElement1.SelectByValue("Max");
////        //    driver.FindElement(By.XPath("//div[@class='_6i1qKy'][normalize-space()='Apple']")).Click();
////        //    driver.FindElement(By.XPath("//div[@title='3★ & above']//div[@class='QCKZip hpLdC3']//div[1]")).Click();
////        //    driver.FindElement(By.XPath("//div[text()='Price -- Low to High']")).Click();
////        //    Thread.Sleep(8000);
////        //    

////        //}


////        //[Test]
////        //public void viewproductdetails()

////        ////view product details
////        //{

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //   Thread.Sleep(7000);
////        //    string ChildWindowName=driver.WindowHandles[1];
////        //     driver.SwitchTo().Window(ChildWindowName);
////        //     Thread.Sleep(1000);

////        //     string s3 =driver.FindElement(By.XPath("//div[@class='Nx9bqj CxhGGd']")).Text;
////        //     Console.WriteLine(s3);
////        //     string s4 = driver.FindElement(By.XPath("//div[@class='Xbd0Sd']")).Text;
////        //     Console.WriteLine(s4);
////        //     bool s5 =driver.FindElement(By.XPath("//div[@class='_8tSq3v']")).Displayed;
////        //     Console.WriteLine(s5);
////        //     Thread.Sleep(6000);


////        //}
////        //[Test]
////        //public void AddProduct()
////        //// Add product to the cart.
////        //{

////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //    Thread.Sleep(7000);
////        //    string ChildWindowName = driver.WindowHandles[1];
////        //    driver.SwitchTo().Window(ChildWindowName);
////        //    driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
////        //    Console.WriteLine(driver.Url);
////        //    Thread.Sleep(3000);
////        //    Thread.Sleep(6000);

////        //}

////        //[Test]
////        //public void ViewCart()
////        //// view Cart
////        //{

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //    Thread.Sleep(7000);
////        //    string ChildWindowName = driver.WindowHandles[1];
////        //    driver.SwitchTo().Window(ChildWindowName);
////        //    driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
////        //    string s2 =driver.FindElement(By.XPath("//a[text()='Apple iPhone 13 (Pink, 128 GB)']")).Text;
////        //    Console.WriteLine(s2);



////        //    Thread.Sleep(1000);
////        //}
////        //[Test]
////        //public void ViewCarRemoveproductfromCart()
////        //// Remove product from  Cart
////        //{

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //    Thread.Sleep(7000);
////        //    string ChildWindowName = driver.WindowHandles[1];
////        //    driver.SwitchTo().Window(ChildWindowName);
////        //    driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
////        //    Thread.Sleep(7000);
////        //    driver.FindElement(By.XPath("//div[text()='Remove']")).Click();
////        //    Thread.Sleep(7000);
////        //    driver.FindElement(By.XPath("//div[@class='sBxzFz fF30ZI A0MXnh']")).Click();
////        //    Thread.Sleep(7000);
////        //    Console.WriteLine(driver.Title);
////        //    string s1 =driver.FindElement(By.XPath("//div[@class='s2gOFd']")).Text;
////        //    Console.WriteLine(s1);

////        //}



////        //}

////        //[Test]
////        //public void Saveproductforlater()
////        //// Save product for later
////        //{

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //    Thread.Sleep(7000);
////        //    string ChildWindowName = driver.WindowHandles[1];
////        //    driver.SwitchTo().Window(ChildWindowName);
////        //    driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
////        //    Thread.Sleep(7000);
////        //    driver.FindElement(By.XPath("//div[text()='Save for later']")).Click();
////        //    Thread.Sleep(7000);

////        //}


////        //[Test]
////        //public void checkproductAvailabilitybyLocation()
////        //// check product Availability by Location 
////        //{

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //    Thread.Sleep(7000);
////        //    string ChildWindowName = driver.WindowHandles[1];
////        //    driver.SwitchTo().Window(ChildWindowName);
////        //    driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2']")).Click();
////        //    Thread.Sleep(7000);
////        //    driver.FindElement(By.XPath("//button[normalize-space()='Enter Delivery Pincode']")).Click();
////        //    Thread.Sleep(3000);
////        //    driver.FindElement(By.XPath("//input[@placeholder='Enter pincode']")).SendKeys("500089");
////        //    Thread.Sleep(3000);
////        //    driver.FindElement(By.XPath("//div[@class='Ji2MFX']")).Click();
////        //    Thread.Sleep(6000);
////        //    string s2 = driver.FindElement(By.XPath("//div[@class='PEuQti']")).Text;
////        //     Console.WriteLine(s2);

////        //}



////        //[Test]
////        //public void checViewCustomerReviewsandRatings()
////        //// View Customer Reviews and Ratings
////        //{

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //    Thread.Sleep(7000);
////        //    string ChildWindowName = driver.WindowHandles[1];
////        //    driver.SwitchTo().Window(ChildWindowName);
////        //    bool s5 = driver.FindElement(By.XPath("//div[@class='row q4T7rk _8-rIO3']")).Displayed;
////        //    Console.WriteLine(s5);
////        //    string s1=driver.FindElement(By.XPath("//div[contains(text(),'Awesome battery backup amazing camera, a all day b')]")).Text;
////        //    Console.WriteLine(s1);

////        //}


////        //[Test]
////        //public void BrowseCategories()
////        //// Browse Categories
////        //{
////        //    driver.FindElement(By.XPath("//span[@class='_1XjE3T']//span[text()='Electronics']")).Click();
////        //    driver.FindElement(By.XPath("//a[@class='_1BJVlg _11MZbx']")).Click();
////        //    Console.WriteLine(driver.Title);
////        //    Thread.Sleep(5000);
////        //}
////        //[Test]
////        //public void CheckOffersandDiscounts()
////        //// Check Offers and Discounts
////        //{

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //    Thread.Sleep(7000);
////        //    string ChildWindowName = driver.WindowHandles[1];
////        //    driver.SwitchTo().Window(ChildWindowName);
////        //    bool s5 = driver.FindElement(By.XPath("//div[@class='I+EQVr']")).Displayed;
////        //    Console.WriteLine(s5);
////        //    String s4 = driver.FindElement(By.XPath("//div[@class='I+EQVr']")).Text;
////        //    Console.WriteLine(s4);
////        //    String s1 = driver.FindElement(By.XPath("//div[@class='hl05eU']")).Text;
////        //    Console.WriteLine(  s1);
////        //    Thread.Sleep(5000);
////        //}

////        //[Test]
////        //public void ViewProductImages()
////        //// View Product Images
////        //{

////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //    Thread.Sleep(7000);
////        //    string ChildWindowName = driver.WindowHandles[1];
////        //    driver.SwitchTo().Window(ChildWindowName);
////        //    driver.FindElement(By.XPath("//div[@class='HXf4Qp SibU2y']//img[@class='_0DkuPH']")).Click();
////        //    Thread.Sleep(6000);
////        //    bool s5 = driver.FindElement(By.XPath("//img[@class='DByuf4 IZexXJ jLEJ7H']")).Displayed;
////        //     Console.WriteLine(s5);
////        //}

////        //[Test]
////        //public void Helpsupport()
////        //// Help
////        //{
////        //    Thread.Sleep(4000);
////        //    driver.FindElement(By.XPath("//a[@title='Dropdown with more help links']")).Click();
////        //    Thread.Sleep(4000);
////        //    driver.FindElement(By.XPath("//li[normalize-space()='24x7 Customer Care']")).Click();
////        //    Thread.Sleep(4000);
////        //    Console.WriteLine(driver.Url);
////        //}

////        //[Test]
////        //public void SearchforProductsinvalidSearch()
////        //// Search for Products-----invalid Search
////        //{
////        //    driver.FindElement(By.Name("q")).SendKeys("hybgdr");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
////        //    Console.WriteLine(driver.Url);
////        //    String s1 = driver.FindElement(By.XPath("//div[text()='Sorry, no results found!']")).Text;
////        //    Console.WriteLine(  s1);
////        //}

////        //[Test]
////        //public void ApplyFiltersonSearchResultsInvalidFilters()
////        //// Apply Filters on Search Results----Invalid Filters
////        //{
////        //    driver.FindElement(By.Name("q")).SendKeys("iphone");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();
////        //    IWebElement Element = driver.FindElement(By.XPath("//div[@class='suthUA']//select[@class='Gn+jFg']"));
////        //    SelectElement selectElement = new SelectElement(Element);
////        //    selectElement.SelectByValue("Min");

////        //    IWebElement Element1 = driver.FindElement(By.XPath("//div[@class='tKgS7w']//select[@class='Gn+jFg']"));

////        //    SelectElement selectElement1 = new SelectElement(Element1);
////        //    Thread.Sleep(10000);
////        //    selectElement1.SelectByValue("20000"); //To Verify dropdown is working or not 
////        //    Thread.Sleep(10000);
////        //    selectElement1.SelectByValue("10000");
////        //    Thread.Sleep(5000);
////        //    String s1 = driver.FindElement(By.XPath("//div[text()='Sorry, no results found!']")).Text;
////        //    Console.WriteLine(  s1);
////        //}
////        //[Test]
////        //public void ADDoutofstockProducttoCart()
////        //// ADD out of stock Product to Cart
////        //{
////        //    driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////        //    driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////        //    driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////        //    Thread.Sleep(7000);
////        //    string ChildWindowName = driver.WindowHandles[1];
////        //    driver.SwitchTo().Window(ChildWindowName);
////        //    driver.FindElement(By.XPath("//input[@class='AFOXgu']")).SendKeys("190001");
////        //    Thread.Sleep(7000);
////        //    driver.FindElement(By.XPath("//span[@class='i40dM4']")).Click();
////        //    Thread.Sleep(7000);
////        //    bool s5 = driver.FindElement(By.XPath("//button[@class='QqFHMw vslbG+ In9uk2 _7dtcvJ']")).Enabled;
////        //    Console.WriteLine(s5);
////        //}
////        //[Test]
////        //public void ViewProductDetailsinvalidProduct()
////        ////View Product Details--- invalid Product 
////        //{


////        //}
////        [Test]
////        public void CheckProductAvailabilityInvalidPINCode()
////        // 20.	Check Product Availability - Invalid PIN Code
////        {
////            driver.FindElement(By.Name("q")).SendKeys("iphone 13");
////            driver.FindElement(By.XPath("//button[@title='Search for Products, Brands and More']//*[name()='svg']")).Submit();


////            driver.FindElement(By.XPath("//div[text()='Apple iPhone 13 (Pink, 128 GB)']")).Click();
////            Thread.Sleep(7000);
////            string ChildWindowName = driver.WindowHandles[1];
////            driver.SwitchTo().Window(ChildWindowName);
////            driver.FindElement(By.XPath("//input[@class='AFOXgu']")).SendKeys("12345");
////            Thread.Sleep(7000);
////            driver.FindElement(By.XPath("//span[@class='i40dM4']")).Click();
////           Thread.Sleep(7000);
////            string s1 = driver.FindElement(By.XPath("//div[@class='nyRpc8']")).Text;
////            Console.WriteLine(s1);
////        }
////        //[Test]
////        //public void CheckProductAvailabilityInvalidPINCode()
////        //// 20.	Check Product Availability - Invalid PIN Code
////        //{

////        //}
////    }
////}