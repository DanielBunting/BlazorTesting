using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.WebDriver.Equip;

namespace BlazorTesting.Selenium
{
    public class FetchDataTests : SeleniumTestBase
    {
        [SetUp]
        public void SetUp()
        {
            BaseSetUp();
        }

        [Test]
        public void FetchDataTests_OnLoad_ReturnsFiveResults()
        {
            Driver.Navigate().GoToUrl($"{Url}/FetchData");
            
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(5000));
            wait.Until(ExpectedCondition.ElementExists(By.TagName("tbody")));

            var wholeTable = Driver.FindElements(By.TagName("tr"));
            
            Assert.AreEqual(6, wholeTable.Count);
        }

        [TearDown]
        public void TearDown()
        {
            BaseTearDown();
        }
    }
}