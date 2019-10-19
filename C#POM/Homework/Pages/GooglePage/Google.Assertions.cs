using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Pages.GooglePage
{
    public partial class Google
    {
        public void AssertSearchResultHeadingText()
        {
            Assert.AreEqual(expectedSeleniumTitle, actualSeleniumTitle);
        }
    }
}
