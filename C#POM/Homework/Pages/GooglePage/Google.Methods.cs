using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages.GooglePage
{
    public partial class Google
    {
        public void SearchGoogle()
        {
            GoogleSearchField.Clear();
            GoogleSearchField.SendKeys(searchInput);
            GoogleSearchField.SendKeys(Keys.Enter);
        }
    }
}
