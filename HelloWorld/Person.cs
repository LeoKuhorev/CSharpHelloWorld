using System;

namespace HelloWorld
{
    public class Person
    {
        static string FirstName;
        static string LastName;

        public string GetFirstName() => FirstName;

        public string GetLastName() => LastName;

        public void SetFirstName(string Name)
        {
            FirstName = Name;
        }
        public void SetLastName(string Name)
        {
            LastName = Name;
        }

        public void Introduce()
        {
            Console.WriteLine($"Hello, my name is {FirstName} {LastName}");
        }
    }
}
