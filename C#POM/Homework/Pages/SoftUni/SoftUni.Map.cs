using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages.SoftUni
{
   public partial class SoftUni : BasePage
    {
        public SoftUni(IWebDriver driver) : base(driver)
        {
        }

        public string SoftUniHomePage = "https://softuni.bg/";

        public IWebElement ButtonCourses => Wait.Until(d => d.FindElement(By.XPath(@"//*[@id='header-nav']/div[1]/ul/li[2]/a/span")));

        public IWebElement ButtonQA => Wait.Until(d => d.FindElement(By.LinkText("QA Automation - септември 2019")));
        
        public string HeadingQA => Wait.Until(d => d.FindElement(By.XPath(@"/html/body/div[2]/header/h1"))).Text;

        public string expectedHeadingText => "QA Automation - септември 2019";


    }
}
