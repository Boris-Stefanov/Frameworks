using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Homework
{
    public partial class HomePage
    {
       

        public void AssertLoginPageLink(string expected, string actual)
        {

            Assert.AreEqual(expected, actual);
        }



    }
}
