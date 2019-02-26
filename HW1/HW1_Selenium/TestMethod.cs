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
        private IWebDriver driver;
        private string link_url = "https://rozetka.com.ua/";

        [Test]
        public void ClickFirstLink()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("--start-maximized");
            driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(link_url);
            new WebDriverWait(driver, TimeSpan.FromSeconds(5)).Until(d => d.Url == link_url);
            IWebElement link = driver.FindElement(By.TagName("a"));
            link.Click();
            driver.Quit();

        }

    }
}
