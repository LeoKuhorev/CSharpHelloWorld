using System;

namespace HelloWorld.Intermediate.AbstractClasses
{
    internal class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Drawing a rectangle");
        }
    }
}