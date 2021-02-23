using System;

namespace HelloWorld.Intermediate.Properties
{
    class Properties
    {
        public static void Demo()
        {
            var person = new Person(new DateTime(1983, 11, 7));
            Console.WriteLine(person.Age);
        }
    }
}
