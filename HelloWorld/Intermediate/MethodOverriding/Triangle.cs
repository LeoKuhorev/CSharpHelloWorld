using System;

namespace HelloWorld.Intermediate.MethodOverriding
{
    class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing a triangle with a height of {Height}");
        }
    }
}