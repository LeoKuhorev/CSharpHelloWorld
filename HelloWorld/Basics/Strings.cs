using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Basics
{
    class Strings
    {
        public static void Demo()
        {
            Console.WriteLine("Strings demo");

            var firstName = "John";
            var lastName = "Dow";
            var fullName = string.Format("Hello, my name is {0} {1}", firstName, lastName);
            Console.WriteLine(fullName);

            var names = new string[3] { "John", "Jake", "Mary" };
            var formattedNames = string.Join(", ", names);
            Console.WriteLine(formattedNames);

            var regularMessage = "Hey John,\nwhen you get a chance take a look at this:\nc:\\directory\\file.exe";
            Console.WriteLine(regularMessage);
            var verbatimMessage = @"Hey John,
when you get a chance take a look at this:
c:\directory\file.exe";
            Console.WriteLine(verbatimMessage);

            var testName = "John Doe...";
            var trimmedName = testName.Trim('.');
            Console.WriteLine($"Trimmed name is: '{trimmedName}'");

            var newFirstName = trimmedName.Substring(0, trimmedName.IndexOf(' '));
            var newLastName = trimmedName.Substring(trimmedName.IndexOf(' '));
            Console.WriteLine($"{newLastName}, {newFirstName}");

            Console.WriteLine("-----------");


        }

        public static void ExerciseOne()
        {
            Console.WriteLine("please enter some numbers separated by a hyphen");
            var userEntry = Console.ReadLine().Split('-');
            var numbers = new List<int>();

            foreach (var s in userEntry)
                numbers.Add(Convert.ToInt32(s));

            Console.WriteLine(IsConsecutive(numbers) ? "Consecutive" : "Not Consecutive");
        }

        public static void ExerciseTwo()
        {
            Console.WriteLine("Please enter some numbers separated by a hyphen (or just press enter to exit)");
            var userEntry = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(userEntry))
                return;

            var strNumbers = userEntry.Split('-');
            if (!IsUnique(strNumbers))
                Console.WriteLine("Duplicate");
        }

        public static void ExerciseThree()
        {
            Console.WriteLine("Please enter a time in military (24hr) format, e.g. '19:46'");
            var userEntry = Console.ReadLine()?.Split(':');
            if (userEntry != null && userEntry.Length == 2)
            {
                Console.WriteLine(IsValidTime(userEntry) ? "Ok" : "Invalid time");
            }
        }

        public static void ExerciseFour()
        {
            Console.WriteLine("Please enter a few words separated by a space");
            var userEntry = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(userEntry))
            {
                Console.WriteLine("Invalid entry");
                return;
            }

            Console.WriteLine(ToPascalCase(userEntry));
        }

        public static void ExerciseFive()
        {
            Console.WriteLine("Please enter a word");
            var userEntry = Console.ReadLine()?.ToLower();
            Console.WriteLine($"This word has {CountVowels(userEntry)} vowels");
        }

        public static bool IsConsecutive(List<int> numbers)
        {
            numbers.Sort();
            for (var i = 1; i < numbers.Count; i++)
            {
                if (numbers[i] != numbers[i - 1] + 1)
                    return false;
            }
            return true;
        }

        public static bool IsUnique(string[] strNumbers)
        {
            var numbers = new List<string>();

            foreach (var s in strNumbers)
                if (numbers.Contains(s))
                    return false;
                else
                    numbers.Add(s);
            return true;
        }

        public static bool IsValidTime(string[] timeString)
        {
            var hours = Convert.ToInt32(timeString[0]);
            var minutes = Convert.ToInt32(timeString[1]);
            if ((hours >= 0 && hours <= 23) && (minutes >= 0 && minutes <= 59))
                return true;
            return false;
        }

        public static string ToPascalCase(string str)
        {
            var output = new StringBuilder();
            foreach (var word in str.Split())
            {
                string firstLetter = word.Substring(0, 1).ToUpper();
                string otherLetters = word.Substring(1).ToLower();
                output.Append($"{firstLetter}{otherLetters}");
            }

            return output.ToString();
        }

        public static int CountVowels(string str)
        {
            var vowels = new List<char>() { 'a', 'e', 'i', 'o', 'u' };
            var count = 0;

            foreach (var character in str)
            {
                if (vowels.Contains(character))
                    count++;
            }

            return count;
        }
    }
}
