using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Intermediate.Indexers
{
    class Indexers
    {
        public static void Demo()
        {
            var cookie = new HttpCookie();
            cookie["name"] = "Jon Doe";
            cookie.Expiring = DateTime.Now.AddDays(1);

            Console.WriteLine(cookie["name"]);
        }
    }
}
