using System;
using Prework;

namespace HelloWorld.Prework
{
    class Exercises
    {
        public static void SwitchCaseDemo()
        {
            Console.WriteLine("Select delivery type id and hit enter: ");

            foreach (DeliveryOptions deliveryOption in Enum.GetValues(typeof(DeliveryOptions)))
                Console.WriteLine($"{deliveryOption} - {(int)deliveryOption}");

            DeliveryOptions deliveryMethod;
            var idSelected = int.TryParse(Console.ReadLine(), out var deliveryId);

            if (idSelected)
                deliveryMethod = (DeliveryOptions)deliveryId;
            else
                throw new ArgumentException("Must select one of the existing delivery types!");

            decimal deliveryCost;
            switch (deliveryMethod)
            {
                case DeliveryOptions.Delivery:
                case DeliveryOptions.ShippingGround:
                    deliveryCost = 10;
                    break;
                case DeliveryOptions.Pickup:
                    deliveryCost = 0;
                    break;
                case DeliveryOptions.Shipping:
                    deliveryCost = 12;
                    break;
                case DeliveryOptions.ShippingAir:
                    deliveryCost = 20;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(deliveryMethod), "You must select one of the existing delivery types!");
            }

            Console.WriteLine($" Your delivery cost is ${deliveryCost}");
        }

    }
}
