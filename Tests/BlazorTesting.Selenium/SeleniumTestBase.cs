using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace BlazorTesting.Selenium
{
    [TestFixture]
    public class SeleniumTestBase
    {
        protected IWebDriver Driver;
        protected string Url;
        
        protected void BaseSetUp()
        {
            var options = new ChromeOptions();
            options.AddArgument("--ignore-certificate-errors");
            options.AddArgument("--headless");
            Driver = new ChromeDriver(options);
            Url = @"https://localhost:5001/";
        }
        
        protected void BaseTearDown()
        {
            Driver.Quit();
        }
    }
}