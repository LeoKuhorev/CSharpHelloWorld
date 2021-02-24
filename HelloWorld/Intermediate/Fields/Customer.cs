using System.Collections.Generic;

namespace HelloWorld.Intermediate.Fields
{
    public class Customer
    {
        public int Id;
        public string Name;
        // readonly modifier protects from re-initializing
        public readonly List<Order> Orders = new List<Order>(); // Can instantiate here to avoid using it in every overload

        public Customer(int id)
        {
            Id = id;
        }

        public Customer(int id, string name)
            : this(id) // Will call the constructor above
        {
            Name = name;
        }

        public void Promote()
        {
            //Orders = new List<Order>(); - this won't work
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}