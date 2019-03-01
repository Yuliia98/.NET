using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace HW1_Selenium
{
 
    public class TestMethod
    {
        private IWebDriver _driver;
        private string _linkToUrl = "https://stylus.ua/";

        [SetUp]
        public void Before()
        {
            var options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            options.AddArgument("--incognito");
            _driver = new ChromeDriver(options);
        }

        [Test]
        public void ClickFirstLink()
        {
            _driver.Navigate().GoToUrl(_linkToUrl);
            _driver.Navigate().GoToUrl(_linkToUrl);
            new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(d => d.Url == _linkToUrl);
            _driver.FindElement(By.XPath("//a[contains(@href, '/promo/events/')]")).Click();
            var activeElement = _driver.FindElement(By.XPath("//a[contains(@href, '/promo/events/')]"));
            Assert.True(activeElement.Text.Contains("Акции"), "Active element doesn't contain 'Акции' ");
            _driver.Quit();


        }

    }
}
