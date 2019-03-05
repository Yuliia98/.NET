using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HW1_Selenium.Pages
{
    public class BasePage
    {
        protected IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
            PageFactory.InitElements(driver, this);
        }
    }
}