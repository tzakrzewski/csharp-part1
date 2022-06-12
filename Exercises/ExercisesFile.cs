using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CsharpPart1
{
    class ExercisesFile
    {
        public void FileFun()
        {
            var path = @"C:\SandBox\CsharpPart1\SampleFiles\TestFileBasic.txt";
            var fileText = File.ReadAllText(path);
            var words = fileText.Replace('\n', ' ').Split(' ');

            var longestWord = "";
            foreach (var word in words)
                if (longestWord.Length < word.Length)
                    longestWord = word;

            Console.WriteLine(fileText);
            Console.WriteLine("Number of Words: " + words.Length);
            Console.WriteLine("Longest Word: " + longestWord);

            foreach(var word in words)
                Console.WriteLine("Word: " + word);
        }
    }
}
//1 - Write a program that reads a text file and displays the number of words.
//2- Write a program that reads a text file and displays the longest word in the file.