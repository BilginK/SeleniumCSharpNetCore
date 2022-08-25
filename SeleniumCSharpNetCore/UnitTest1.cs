using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        public IWebDriver Driver;

        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
            ChromeOptions options = new ChromeOptions();
            Driver = new ChromeDriver();
        }



        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");

            Driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Tomato");
            Driver.FindElement(By.XPath("(//input[@name='ctl00$ContentPlaceHolder1$ChildMeal1'])[1]")).Click();

            Console.WriteLine("Test 1");
            Console.ReadLine();
            Assert.Pass();
        }
    }
}