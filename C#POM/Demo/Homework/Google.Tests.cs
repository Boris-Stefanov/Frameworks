using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using System.Text;

namespace Homework.Pages.GooglePage
{
    [TestFixture]
    public  class GoogleTests
    {
        private IWebDriver driver;
        private Google googlePage;

        [SetUp]
        public void BeforeMethod()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            googlePage = new Google(driver);


        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void searchSelenium()
        {
            googlePage.Navigate(googlePage.GoogleHomePage);
            googlePage.SearchGoogle();
            googlePage.ButtonSearchResult.Click();

            googlePage.AssertSearchResultHeadingText();
        }

    }
}
