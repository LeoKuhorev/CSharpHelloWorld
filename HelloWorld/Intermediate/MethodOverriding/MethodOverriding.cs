using System.Collections.Generic;

namespace HelloWorld.Intermediate.MethodOverriding
{
    public class MethodOverriding
    {
        public static void MethodOverridingDemo()
        {
            var circle = new Circle() { Width = 100, Height = 100};
            var rectangle = new Rectangle() {Width = 100, Height = 200};
            var triangle = new Triangle() {Width = 100, Height = 200};
            //var canvas = new Canvas();
            Canvas.DrawShapes(new List<Shape>() { circle, rectangle, triangle});
        }
    }
}