using System;
using System.Runtime.InteropServices;
using System.Text;

namespace HelloWorld.Intermediate.Fields
{
    class Fields
    {
        public static void Demo()
        {
            var customer = new Customer(1);
            customer.AddOrder(new Order());
            customer.AddOrder(new Order());
            Console.WriteLine(customer.Orders.Count);
        }
    }
}
