using NUnit.Framework;

namespace Homework.Pages
{
    public partial class RegistrationPage
    {

        public void AssertErrorMessage(string expected, string actual)
        {
            
            Assert.AreEqual(expected, actual);
        }



    }
}
