namespace Homework
{
    public static class UserFactory
    {
        public static RegistrationUser CreateValidUser()
        {
            return new RegistrationUser
            {
                FirstName = "Ventsi",
                LastName = "Batman",
                //Year = "1985",
                //Month = "April",
                //Date = "3",
                Password = "gdsjafgujdsw",
                RealFirstName = "James",
                RealLastName = "Bond",
                Address = "UK",
                City = "Chester",
                State = "Utah",
                Zip = "4324422",
                Phone = "+44 000000",
                Alias = "don't die today"
            };
        }
    }
}
