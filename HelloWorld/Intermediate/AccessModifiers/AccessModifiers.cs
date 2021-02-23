using System;

namespace HelloWorld.Intermediate
{
    class AccessModifiers
    {
        public static void Demo()
        {
            var person = new Person();
            person.SetBirthdate(new DateTime(2010,1,1));
            person.SetBirthdate(new DateTime(1983, 1,1));

            Console.WriteLine(person.GetBirthday());
        }
    }
}
