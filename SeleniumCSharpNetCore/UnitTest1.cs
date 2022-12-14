using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        public IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            ChromeOptions options = new ChromeOptions();
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

                      
        }
        
        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            //Driver.FindElement(By.XPath("(//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1'])[1]")).Click();

            Console.WriteLine("Test 1");
            Assert.Pass();
        }

        [TearDown]
        public void AfterTest()
        {
            driver.Quit();
        }
    }
}