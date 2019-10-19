using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework
{
    public partial class HomePage : BasePage
    {
        public HomePage(IWebDriver driver)
            : base(driver)
        {
        }

        public string HomeUrl => "http://automationpractice.com/index.php";

        public IWebElement SignInButton => Driver.FindElement(By.XPath("//*[@id='header']/div[2]/div/div/nav/div[1]/a"));

        public string actualLinkUrl => Driver.Title;

        public string expectedLinkUrl => "Login - My Store";

       
    }
}
