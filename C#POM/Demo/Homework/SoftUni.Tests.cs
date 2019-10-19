using Homework.Pages.SoftUni;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace Homework.Pages.SoftUni
{
    [TestFixture]
    class SoftUniTests
    {
        private IWebDriver driver;
        private SoftUni softUniPage;

        [SetUp]
        public void BeforeMethod()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();
            softUniPage = new SoftUni(driver);
            

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        

        [Test]
        public void VerifyQAHeadingText()
        {
            softUniPage.Navigate(softUniPage.SoftUniHomePage);
            softUniPage.ButtonCourses.Click();
            softUniPage.ScrollToElement();

            softUniPage.AssertHeadingText(softUniPage.expectedHeadingText, softUniPage.HeadingQA);
        }

    }
}
