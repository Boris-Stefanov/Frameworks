using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages.GooglePage
{
    public partial class Google : BasePage
    {
        public Google(IWebDriver driver) : base(driver)
        {
        }

        public string GoogleHomePage => "https://www.google.com/";

        public IWebElement GoogleSearchField => Driver.FindElement(By.XPath("//*[@id='tsf']/div[2]/div[1]/div[1]/div/div[2]/input"));

        public string searchInput = "selenium";

        public IWebElement ButtonSearchResult => Wait.Until(d => d.FindElement(By.XPath("//*[@id='rso']/div[1]/div/div/div/div[1]/a[1]/h3")));

        public string actualSeleniumTitle => Driver.Title;

        public string expectedSeleniumTitle => "Selenium - Web Browser Automation";
    }
}
