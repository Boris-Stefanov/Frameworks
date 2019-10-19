using NUnit.Framework;
using System;



namespace Homework.Pages.SoftUni
{
    public partial class SoftUni
    {

        public void AssertHeadingText(string expected, string actual)
        {
            Assert.AreEqual(expected, actual);
        }

    }
}
