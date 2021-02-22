using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Intermediate.Methods
{
    class Program
    {
        public static void Demo()
        {
            UsePoints();
            UseParams();
            UseOut();
        }

        static void UseOut()
        {
            try
            {
                var numberOne = int.Parse("abc"); //invalid string - raises exception

            }
            catch (Exception )
            {
                Console.WriteLine("Conversion one failed");
            }

            int numberTwo;
            var result = int.TryParse("abd", out numberTwo);

            if (result)
                Console.WriteLine(numberTwo);
            else
                Console.WriteLine("Conversion two failed");
        }

        static void UseParams()
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(1, 2, 3));
            Console.WriteLine(calculator.Add(1, 2, 3, 4, 5, 6));
            Console.WriteLine(calculator.Add(new[] { 1, 2, 3 }));
        }

        static void UsePoints()
        {
            try
            {
                var point = new Point(10, 20);
                Console.WriteLine($"point.X: {point.X}, point.Y: {point.Y}");

                point.Move(20, 30);
                Console.WriteLine($"point.X: {point.X}, point.Y: {point.Y}");

                Console.WriteLine($"point.X: {point.X}, point.Y: {point.Y}");
                point.Move(new Point(56, 60));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
