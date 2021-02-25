using System;

namespace HelloWorld.Intermediate.AbstractClasses
{
    public class AbstractClasses
    {
        public static void AbstractClassesDemo()
        {
            try
            {
                //var shape = new Shape(); // Cannot create an instance of the abstract type or interface 'Shape'

                var circle = new Circle();
                var rectangle = new Rectangle();
                circle.Draw();
                rectangle.Draw();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}