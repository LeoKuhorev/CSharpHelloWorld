using System;

namespace HelloWorld.Basics
{
    class Loops
    {
        public static void ExerciseOne()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        public static void ExerciseTwo()
        {
            var @sum = 0;
            while (true)
            {
                Console.WriteLine("Please enter a number (enter \"ok\" to exit)");
                var userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "ok")
                {
                    break;
                }

                @sum += Convert.ToInt32(userAnswer);
            }

            Console.WriteLine(@sum > 0 ? $"The sum of the entered numbers is {@sum}" : "You didn't enter any numbers");
        }

        public static void ExerciseThree()
        {
            Console.WriteLine("Please enter a number");
            var userAnswer = Convert.ToInt32(Console.ReadLine());

            var output = 1;
            for (var i = 1; i <= userAnswer; i++)
            {
                output *= i;
            }

            Console.Out.WriteLine($"{userAnswer}! = {output}");
        }

        public static void ExerciseFour()
        {
            var random = new Random();
            var actualNumber = random.Next(1, 10);
            const int numberOfGuesses = 4;
            string message = $"You lost! (The actual number was {actualNumber})";
            for (var i = 0; i < numberOfGuesses; i++)
            {
                Console.WriteLine($"Guess a number between 1 and 10 ({numberOfGuesses - i} attempts left)");
                var userAnswer = Convert.ToInt32(Console.ReadLine());
                if (userAnswer == actualNumber)
                {
                    message = "You won!";
                    break;
                }
            }

            Console.WriteLine(message);
        }

        public static void ExerciseFive()
        {
            Console.WriteLine("Please enter a sequence of numbers separated by comma");
            var userAnswer = Console.ReadLine();
            var numbers = userAnswer.Split(',');
            var max = int.MinValue;
            foreach (var number in numbers)
            {
                max = System.Math.Max(max, Convert.ToInt32(number));
            }

            Console.WriteLine($"The maximum number is: {max}");
        }
    }
}
