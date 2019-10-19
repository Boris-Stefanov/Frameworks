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
    public partial class SoftUni
    {
        

        public void ScrollToElement()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
            js.ExecuteScript("window.scrollBy(0, 250)", "");
            ButtonQA.Click();
        }

    }
}
