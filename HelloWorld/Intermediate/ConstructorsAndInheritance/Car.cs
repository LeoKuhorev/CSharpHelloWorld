using System;

namespace HelloWorld.Intermediate.ConstructorsAndInheritance
{
    class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine($"Car number {registrationNumber} is being initialized");   
        }
    }
}