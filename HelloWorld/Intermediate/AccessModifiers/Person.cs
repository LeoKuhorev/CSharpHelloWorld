using System;

namespace HelloWorld.Intermediate
{
    public class Person
    {
        private DateTime _birthdate;

        public void SetBirthdate(DateTime birthdate)
        {
            var now = DateTime.Now;
            if ((now.Year - birthdate.Year) >= 18)
                _birthdate = birthdate;
            else
                Console.WriteLine("Must be at least 18 years");
        }

        public DateTime GetBirthday()
        {
            return _birthdate;
        }
    }
}