using System;
using System.Collections.Generic;

namespace HelloWorld.Intermediate.Casting
{
    public class Casting
    {
        public static void Demo()
        {
            // Upcasting
            Text text = new Text();
            Shape shape = text; // Can implicitly cast an instance of a derived class to its base class

            // Both of these point to the same object in memory
            text.Width = 200;
            shape.Width = 100;
            Console.WriteLine(text.Width); //100

            var list = new List<Shape>() {text, shape}; // can implicitly cast text into a shape
            foreach (var obj in list)
            {
                Console.WriteLine(obj.Width);
            }

            // Downcasting
            Shape shape1 = new Text(); // shape1 has only properties from the base class
            Text text1 = (Text) shape1; // text1 has properties of both base and derived class

        }

    }
}