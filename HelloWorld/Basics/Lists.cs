using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Basics
{
    class Lists
    {
        public static void Demo()
        {
            var numbers = new List<int>() { 1, 2, 3, 4 };

            // Add()
            numbers.Add(1);

            // AddRange()
            numbers.AddRange(new int[] { 6, 7, 8, 9 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // IndexOf()
            Console.WriteLine("Index of 1st 1: " + numbers.IndexOf(1));

            // LastIndexOf()
            Console.WriteLine("Last index of 1: " + numbers.LastIndexOf(1));

            // Count
            Console.WriteLine("The number of objects on the list" + numbers.Count);

            // Remove all occurrences
            var target = 1;
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == target)
                {
                    numbers.Remove(numbers[i]);
                }
            }

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            // Remove all elements from the list
            numbers.Clear();
        }

        public static void ExerciseOne()
        {
            var names = new List<string>();

            while (true)
            {
                Console.WriteLine("Please enter a name (or hit enter to exit)");
                var userEntry = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(userEntry))
                    break;
                names.Add(userEntry);
            }

            if (names.Count > 2)
                Console.WriteLine($"{names[0]}, {names[1]} and {names.Count - 2} others like your post");
            else if (names.Count == 2)
                Console.WriteLine($"{names[0]} and {names[1]} like your post");
            else if (names.Count == 1)
                Console.WriteLine($"{names[0]} likes your post");
            else
                Console.WriteLine();
        }

        public static void ExerciseTwo()
        {
            Console.WriteLine("Please enter a name");
            var name = Console.ReadLine();
            var nameArray = new char[name.Length];

            for (var i = 0; i < name.Length; i++)
                nameArray[i] = (char)name[i];

            Array.Reverse(nameArray);

            var output = string.Join("", nameArray);
            Console.WriteLine(output);
        }

        public static void ExerciseThree()
        {
            var numbers = new List<int>();

            for (var i = 0; i < 5; i++)
            {
                Console.WriteLine("Please enter 5 unique numbers");
                var userAnswer = Convert.ToInt32(Console.ReadLine());
                if (numbers.Contains(userAnswer))
                {
                    Console.WriteLine("This number wasn't unique");
                    i--;
                    continue;
                }
                numbers.Add(userAnswer);
            }

            numbers.Sort();

            foreach (var number in numbers)
                Console.Write(number);

        }

        public static void ExerciseFour()
        {
            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Please enter a number");
                var userAnswer = Console.ReadLine();
                if (userAnswer.ToLower() == "quit")
                    break;
                var number = Convert.ToInt32(userAnswer);
                if (!numbers.Contains(number))
                    numbers.Add(number);
            }

            foreach (var number in numbers)
                Console.Write(number);
        }

        public static void ExerciseFive()
        {
            Console.WriteLine("Please enter a list of comma separated numbers (make sure it has more than 5 numbers)");
            while (true)
            {
                var userAnswer = Console.ReadLine();
                var strNumbers = userAnswer.Split(',');
                if (strNumbers.Length < 5)
                {
                    Console.WriteLine("Invalid list, please retry");
                    continue;
                }

                var numbers = new int[strNumbers.Length];
                for (var i = 0; i < strNumbers.Length; i++)
                    numbers[i] = Convert.ToInt32(strNumbers[i]);
                Array.Sort(numbers);
                Console.WriteLine($"The 3 smallest numbers are  {numbers[0]}, {numbers[1]}, and {numbers[2]}");
                break;
            }

        }

    }
}
