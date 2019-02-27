using System;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI; 

namespace HW1_Selenium
{
    public class TestClass
    {
        private IWebDriver _driver;
        private string _linkUrl; 

        [SetUp]
        public void Before()
        {
            var options = new ChromeOptions();
            options.AddArgument("--incognito");
            options.AddArgument("--start-maximized");
            _driver = new ChromeDriver(options);
        }

        [Test] 
        public void ClickContactsLinkAndCheckThatItemIsActive() 
        {
            _linkUrl = "https://rozetka.com.ua/";
            _driver.Navigate().GoToUrl(_linkUrl);
            new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(driver => driver.Url == _linkUrl); 

            _driver.FindElement(By.XPath("//li[@class='header-topline__links-item']/a[contains(@href, 'contacts')]")).Click();
            var activeMenuItem = _driver.FindElement(By.XPath("//li[@class='m-static-i active']")); 

            Assert.True(activeMenuItem.Text.Contains("Контакт"), "Active Menu Item does not contain 'Контакт'!");

            _driver.Quit();
        }

        [Test] 
        public void ClickAndCheck() 
        {
            _linkUrl = "https://www.epam.com/";
            _driver.Navigate().GoToUrl(_linkUrl);
            new WebDriverWait(_driver, TimeSpan.FromSeconds(5)).Until(driver => driver.Url == _linkUrl); 

            _driver.FindElement(By.XPath("XXXXXXXXXXXXXXXXXXXXXXXXXXXXX")).Click();
            var activeMenuItem = _driver.FindElement(By.XPath("XXXXXXXXXXXXXXXXXX")); 

            Assert.True(activeMenuItem.Text.Contains("XXXXXXXXXX"), "Active Menu Item does not contain 'XXXXXXXXX'!");

            _driver.Quit();
        }
    }
}
