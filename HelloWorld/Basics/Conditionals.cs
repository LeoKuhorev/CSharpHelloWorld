using System;

namespace HelloWorld.Basics
{
    class Conditionals
    {
        public static void Demo()
        {
            Console.WriteLine("Conditionals demo");
            var hour = 10;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("it's morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("it's afternoon");
            }
            else
            {
                Console.WriteLine("it's evening");
            }


            // Conditional
            bool isGoldCustomer = true;
            var price = isGoldCustomer ? 19.95f : 29.95f;
            Console.WriteLine("price: $" + price);


            // switch-case
            var season = Seasons.Spring;

            switch (season)
            {
                case Seasons.Winter:
                case Seasons.Autumn:
                    Console.WriteLine("it's cold");
                    break;

                case Seasons.Spring:
                case Seasons.Summer:
                    Console.WriteLine("it's warm");
                    break;

                default:
                    Console.WriteLine("there's no such season");
                    break;
            }

            Console.WriteLine("-----------");
        }

        public static void ExerciseOne()
        {
            Console.WriteLine("Please enter a number between 0 and 10");
            var userInput = Convert.ToInt32(Console.ReadLine());
            var random = new Random();
            var actualNumber = random.Next(10);
            var Attempts = 5;
            var count = 0;

            while (userInput != actualNumber && ++count < Attempts)
            {
                Console.WriteLine("Nope, please try again");
                userInput = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(userInput == actualNumber
                ? $"Yay! It's {actualNumber} indeed"
                : $"Well, the actual number was {actualNumber}");
        }

        public static void ExerciseTwo()
        {
            Console.WriteLine("Please enter the first number");
            var numberOne = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the second number");
            var numberTwo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine((numberOne > numberTwo) ? numberOne : numberTwo);
        }

        public static void ExerciseThree()
        {
            Console.WriteLine("Please enter the image width");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the image height");
            var height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? "Landscape" : width < height ? "Portrait" : "Square";

            Console.WriteLine($"Your image is {orientation} orientation");
        }

        public static void ExerciseFour()
        {
            Console.WriteLine("Please enter the speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the speed of the car");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            int points = carSpeed > speedLimit ? (carSpeed - speedLimit) / 5 : 0;

            Console.WriteLine(points >= 12 ? "License suspended" : points > 0 ? $"Demerit points: {points}" : "OK");
        }

        public static void Loops()
        {
            var random = new Random();
            const int length = 10;
            var buffer = new char[length];

            for (var i = 0; i < length; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            var output = new string(buffer);
            Console.WriteLine(output);
        }
    }
}
