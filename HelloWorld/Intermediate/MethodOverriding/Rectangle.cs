using System;

namespace HelloWorld.Intermediate.MethodOverriding
{
    class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing a rectangle {Width} x {Height}");
        }
    }
}