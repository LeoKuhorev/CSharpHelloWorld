using System.Collections.Generic;

namespace HelloWorld.Intermediate.MethodOverriding
{
    class Canvas
    {
        public static void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
        }
    }
}