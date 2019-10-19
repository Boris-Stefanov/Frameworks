using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Homework
{
    [TestFixture]
    public  class HomePageTests
    {
        private HomePage homePage;
        private IWebDriver driver;

        [SetUp]
        public void BeforeMethod()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            homePage = new HomePage(driver);
            
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void NavigateToLoginPage()
        {
            
            homePage.Navigate(homePage.HomeUrl);
            homePage.SignInButton.Click();
            
            homePage.AssertLoginPageLink(homePage.expectedLinkUrl, homePage.actualLinkUrl);
        }

    }
}
