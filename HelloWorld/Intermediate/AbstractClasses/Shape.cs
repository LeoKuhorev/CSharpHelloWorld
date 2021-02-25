using System;

namespace HelloWorld.Intermediate.AbstractClasses
{
    public abstract class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public abstract void Draw();

        public void Copy()
        {
            Console.WriteLine("The shape copied into the clipboard");
        }
    }
}