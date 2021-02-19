using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HelloWorld.Basics
{
    class IO
    {
        public static void Demo()
        {
            const string PathOne = @"d:\Leo\Coding\C#\HelloWorld\HelloWorld\Assets\fileOne.txt";
            const string PathTwo = @"d:\Leo\Coding\C#\HelloWorld\HelloWorld\Assets\fileTwo.txt";

            // Static methods
            File.Copy(PathOne, PathTwo, true);
            File.Delete(PathOne);
            if (File.Exists(PathOne))
            {
                File.ReadAllText(PathTwo);
            }

            // Instance methods
            var file = new FileInfo(PathOne);
            file.CopyTo(PathTwo);
            if (file.Exists)
                file.Delete();

            // Directory
            Directory.CreateDirectory(@"");
            var files = Directory.GetFiles(@"", "*.cs");
            var directories = Directory.GetDirectories(@"", "*.*");
            Directory.Exists(@"");

            // DirectoryInfo
            var directory = new DirectoryInfo(@"");
            var name = directory.Name;

            // Path
            var extension = Path.GetExtension(PathOne);
            var fileName = Path.GetFileName(PathOne);
            var shortFileName = Path.GetFileNameWithoutExtension(PathOne);


        }

        public static void SaveUserEntry(string path)
        {
            Console.WriteLine("Please enter some text");
            var userEntry = Console.ReadLine();
            File.WriteAllText(path, userEntry);
        }

        public static string GetLongestWord(string[] words)
        {
            var maxLength = 0;
            var longestWord = "";

            foreach (var word in words)
            {
                if (word.Length > maxLength)
                    longestWord = word;
            }

            return longestWord;
        }
        public static void ExerciseOne()
        {
            var path = @"d:\Leo\Coding\C#\HelloWorld\HelloWorld\Assets\exerciseOne.txt";
            SaveUserEntry(path);
            
            var text = File.ReadAllText(path);
            Console.WriteLine($"You wrote {text.Split().Length} words");
        }

        public static void ExerciseTwo()
        {
            var path = @"d:\Leo\Coding\C#\HelloWorld\HelloWorld\Assets\exerciseTwo.txt";
            SaveUserEntry(path);
            
            var text = File.ReadAllText(path);
            Console.WriteLine($"The longest word is {GetLongestWord(text.Split())}");
        }


    }
}
