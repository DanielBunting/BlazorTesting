using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Selenium.WebDriver.Equip;

namespace BlazorTesting.Selenium
{
    public class CounterTests : SeleniumTestBase
    {
        [SetUp]
        public void SetUp()
        {
            BaseSetUp();
        }

        [Test]
        public void Counter_OnButtonClick_ShouldIncrement()
        {
            Driver.Navigate().GoToUrl($"{Url}/Counter");
            var wait = new WebDriverWait(Driver, TimeSpan.FromMilliseconds(5000));
            wait.Until(ExpectedCondition.ElementExists(By.TagName("button")));
            Assert.AreEqual("Current count: 0", Driver.FindElement(By.TagName("p")).Text);
            Driver.FindElement(By.CssSelector(".btn")).Click();

            Assert.AreEqual("Current count: 1", Driver.FindElement(By.TagName("p")).Text);
        }

        [TearDown]
        public void TearDown()
        {
            BaseTearDown();
        }
    }
}