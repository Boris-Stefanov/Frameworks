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

         /* ChromeOptions options = new ChromeOptions();
            options.PlatformName = "windows";
            options.BrowserVersion = "77.0";
            driver = new RemoteWebDriver(new Uri("http://192.168.0.104:4444/wd/hub"), options.ToCapabilities(), TimeSpan.FromSeconds(10));
            driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30); */

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
