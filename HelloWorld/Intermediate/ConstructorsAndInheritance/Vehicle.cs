using System;

namespace HelloWorld.Intermediate.ConstructorsAndInheritance
{
    class Vehicle
    {
        private readonly string _registrationNumber;

        public Vehicle(string registrationNumber)
        {
            _registrationNumber = registrationNumber;
            Console.WriteLine($"Vehicle number {registrationNumber} is being initialized");
        }
    }
}