using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.WebDriver.Equip;

namespace BlazorTesting.Selenium
{
    public class IndexTests : SeleniumTestBase
    {
        [SetUp]
        public void SetUp()
        {
            BaseSetUp();
        }

        [Test]
        public void OnPageRender_HeaderOneElement_ShouldDisplayHelloWorld()
        {
            Driver.Navigate().GoToUrl($"{Url}");
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(5000));
            wait.Until(ExpectedCondition.ElementExists(By.TagName("h1")));

            Assert.AreEqual("Hello, world!", Driver.FindElement(By.TagName("h1")).Text);
        }

        [TearDown]
        public void TearDown()
        {
            BaseTearDown();
        }
    }
}