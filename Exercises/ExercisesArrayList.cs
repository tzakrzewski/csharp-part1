using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart1
{
    class ExercisesArrayList
    {
        public void ArrayListOne()
        {
            Console.WriteLine("Enter Names : ");
            var listOfNames = new List<string>();
            while (true)
            {
                var input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                    break;
                listOfNames.Add(input);
            }

            switch (listOfNames.Count)
            {
                case 0:
                    Console.WriteLine("Nothing to display");
                    break;
                case 1:
                    Console.WriteLine(String.Format("{0} likes your post.", listOfNames[0]));
                    break;
                case 2:
                    Console.WriteLine(String.Format("{0} and {1} like your post.", listOfNames[0], listOfNames[1]));
                    break;
                default:
                    Console.WriteLine(String.Format("{0}, {1} and {2} others like your post.", listOfNames[0], listOfNames[1], listOfNames.Count - 2));
                    break;
            }
        }

        public void ArrayListTwo()
        {
            Console.WriteLine("Enter Name: ");
            var name = Console.ReadLine();
            var reversedName = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                reversedName[name.Length - i] = name[i - 1];
            Console.WriteLine(new string(reversedName));
        }

        public void ArrayListThree()
        {
            Console.WriteLine("Enter 5 Numbers: ");
            var numList = new List<int>();
            while (numList.Count < 5)
            {
                var input = Convert.ToInt32(Console.ReadLine());
                if (!numList.Contains(input))
                    numList.Add(input);
                else
                    Console.WriteLine("Number Exists!");
            }
            numList.Sort();
            foreach (var num in numList)
                Console.Write(num + " ");
        }

        public void ArrayListFour()
        {
            Console.WriteLine("Enter Numbers: ");
            var numList = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                if ("Quit" == input)
                    break;
                var num = Convert.ToInt32(input);
                numList.Add(num);
            }
            var uniques = new List<int>();
            foreach (var number in numList)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
            }

            Console.WriteLine("Unique numbers:");
            foreach (var number in uniques)
                Console.WriteLine(number);
        }

        public void ArrayListFive()
        {
            Console.WriteLine("Enter list of Numbers: ");
            var numList = new List<int>();
            while (true)
            {
                var input = Console.ReadLine();
                var numbers = input.Split(',');
                foreach (var num in numbers)
                    numList.Add(Convert.ToInt32(num));
                if (numList.Count > 4)
                    break;
                else
                    Console.WriteLine("Invalid List");
            }
            numList.Sort();
            Console.WriteLine(numList[0] + " " + numList[1] + " " + numList[2]);
        }
    }
}
//1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.
//  If no one likes your post, it doesn't display anything.
//  If only one person likes your post, it displays: [Friend's Name] likes your post.
//  If two people like your post, it displays: [Friend 1] and[Friend 2] like your post.
//  If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] others like your post.
//  Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name).
//  Depending on the number of names provided, display a message based on the above pattern.
//2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in a new string.
//  Display the reversed name on the console.
//3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the
//  user to re-try. Once the user successfully enters 5 unique numbers, sort them and display the result on the console.
//4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may include duplicates.
//  Display the unique numbers that the user has entered.
//5- Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is empty or includes
//  less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.

