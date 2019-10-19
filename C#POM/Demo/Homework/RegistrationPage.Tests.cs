using Homework.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using System.Threading;

namespace Homework
{
    [TestFixture]
    public class RegistrationPageTests// : RegistrationPage
    {
        private LoginPage _loginPage;
        private RegistrationPage _regPage;
        private RegistrationUser _user;
        private IWebDriver driver;

        /*public RegistrationPageTests(IWebDriver driver) : base(driver)
        {
        }*/

        [SetUp]
        public void BeforeMethod()
        {
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            driver.Manage().Window.Maximize();

            _loginPage = new LoginPage(driver);
            _regPage = new RegistrationPage(driver);

            _user = UserFactory.CreateValidUser();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

       

        [Test]
        public void FillRegistrationFormWithoutFirstName()
        {
            _user.FirstName = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
 
            _regPage.AssertErrorMessage(_regPage.errorMessageExpectedFirstName, _regPage.errorMessageFirstName);
        }

        [Test]
        public void FillRegistrationFormWithoutLastName()
        {
            _user.LastName = "";
            
            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);
            
            _regPage.AssertErrorMessage(_regPage.errorMessageExpectedLastName, _regPage.errorMessageLastName);
        }

        [Test]
        public void FillRegistrationFormWithoutPassword()
        {
            _user.Password = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage(_regPage.errorMessageExpectedPassword, _regPage.errorMessagePassword);
        }

        [Test]
        public void FillRegistrationFormWithoutCity()
        {
            _user.City = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage(_regPage.errorMessageExpectedCity, _regPage.errorMessageCity);
        }

        [Test]
        public void FillRegistrationFormWithoutZip()
        {
            _user.Zip = "";

            _regPage.Navigate(_loginPage);
            _regPage.FillForm(_user);

            _regPage.AssertErrorMessage(_regPage.errorMessageExpectedZip, _regPage.errorMessageZip);
        }

    }
}
