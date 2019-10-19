using Homework.Extensions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Homework.Pages
{
    public partial class RegistrationPage
    {

        public void FillForm(RegistrationUser user)
        {
            RadioButtons.Click();
            CustomerFirstName.Type(user.FirstName);
            CustomerLastName.Type(user.LastName);
            Password.Type(user.Password);
            //Days.SelectByText(user.Date);
            //Months.SelectByText(user.Month);
            //Years.SelectByText(user.Year);
            FirstName.Type(user.RealFirstName);
            LastName.Type(user.RealLastName);
            Address.Type(user.Address);
            City.Type(user.City);
            State.SelectByText(user.State);
            Zip.Type(user.Zip);
            Phone.Type(user.Phone);
            Alias.Type(user.Alias);
            RegisterButton.Click();
        }

        public void Navigate(LoginPage loginPage)
        {
            loginPage.Navigate("http://automationpractice.com/index.php?controller=my-account");
            loginPage.Email.SendKeys("djburfguygfyuooooooo1@gmail.com");
            loginPage.Submit.Click();
        }
    }
}
