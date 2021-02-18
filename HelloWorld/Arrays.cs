using System;
using System.Runtime.InteropServices.ComTypes;

namespace HelloWorld
{
    public class Arrays
    {
        public static void Demo()
        {
            Console.WriteLine("Arrays demo");
            var numbers = new int[3];
            numbers[0] = 1;
            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            var booleans = new bool[4];
            booleans[0] = true;
            Console.WriteLine(booleans[0]);
            Console.WriteLine(booleans[1]);
            Console.WriteLine(booleans[2]);
            Console.WriteLine("-----------");

            var names = new string[3] {"John", "Jake", "Mary"};

            var newNumbers = new[] {2, 2, 1, 4, 5, 3, 8, 3};
            foreach (var number in newNumbers)
            {
                Console.Write(number);
            }

            // Length
            Console.WriteLine("\nThe length of the array is: " + newNumbers.Length);

            // IndexOf()
            Console.WriteLine("The index of 5 is: " + Array.IndexOf(newNumbers, 5));

            // Clear()
            Array.Clear(newNumbers, 2, 3);
            Console.WriteLine("Array after applying Clear() method");
            foreach (var number in newNumbers)
            {
                Console.Write(number);
            }

            // Copy()
            var anotherArray = new int[3];
            Array.Copy(newNumbers, anotherArray, 3);
            Console.WriteLine("\nCopy 3 elements into a new array");

            foreach (var i in anotherArray)
            {
                Console.Write(i);
            }

            // Sort()
            Array.Sort(newNumbers);
            Console.WriteLine("\nSorting the original array");

            foreach (var number in newNumbers)
            {
                Console.Write(number);
            }

            // Reverse()
            Console.WriteLine("\nReversing the original array");
            Array.Reverse(newNumbers);

            foreach (var number in newNumbers)
            {
                Console.Write(number);
            }

   
        }
    }
}