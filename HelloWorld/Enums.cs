using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace HelloWorld
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class Enums
    {
        public static void Demo()
        {
            Console.WriteLine("Enums demo");

            // Get value from the enum
            var method = ShippingMethod.Express;
            Console.WriteLine(method); // console.WriteLine automatically converts everything into a string
            Console.WriteLine(method.ToString()); // explicit conversion into a str

            // Cast into an integer
            Console.WriteLine((int)method);

            var methodId = 3;
            Console.WriteLine((ShippingMethod)methodId);

            var methodName = "Express";
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine("Shipping Method: " + shippingMethod);
            

            Console.WriteLine("-----------");
        }
    }
}
