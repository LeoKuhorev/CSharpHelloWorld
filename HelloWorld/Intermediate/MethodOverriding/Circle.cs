using System;

namespace HelloWorld.Intermediate.MethodOverriding
{
    class Circle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine($"Drawing a circle with the radius of {Width}");
        }
    }
}