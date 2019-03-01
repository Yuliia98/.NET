using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HW1_Selenium.Pages
{
    public class MainPage : BasePage
    {
       public MainPage(IWebDriver driver) : base(driver) 
       {
       } 

        [FindsBy(How = How.XPath, Using = "//ul[@class='header-top-menu']/li/a[contains(@href, '/promo/events/')]")]
        public IWebElement PromoButton;
    }
}