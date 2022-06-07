using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart1
{
    class ExercisesText
    {
        public void TextOne()
        {

            Console.WriteLine("Enter Consecutive Numbers: ");
            var inputs = Console.ReadLine();

            var nums = new List<int>();
            foreach (var input in inputs.Split('-'))
                nums.Add(Convert.ToInt32(input));
            
            nums.Sort();
            
            for (var i = 1; i < nums.Count; i++)
            {
                if (nums[i] != nums[i - 1] + 1)
                {
                    nums.Clear();
                    break;
                }
            }
            
            var messsage = (nums.Count > 0) ? "Consecutive" : "Not Consecutive";
            Console.WriteLine(messsage);
        }

        public void TextTwo()
        {
            Console.Write("Enter a few numbers (eg 1-2-3-4): ");
            var input = Console.ReadLine();

            if (String.IsNullOrWhiteSpace(input))
                return;

            var numbers = new List<int>();
            foreach (var number in input.Split('-'))
                numbers.Add(Convert.ToInt32(number));

            var uniques = new List<int>();
            var includesDuplicates = false;
            foreach (var number in numbers)
            {
                if (!uniques.Contains(number))
                    uniques.Add(number);
                else
                {
                    includesDuplicates = true;
                    break;
                }
            }

            if (includesDuplicates)
                Console.WriteLine("Duplicate");
        }

        public void TextThree()
        {
            Console.WriteLine("Enter Time: ");
            var inputs = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputs))
            {
                Console.WriteLine("Invalid");
                return;
            }

            var nums = new List<int>();
            foreach (var input in inputs.Split(':'))
                nums.Add(Convert.ToInt32(input));

            if(nums[0] >= 0 && nums[0] <=24 && nums[1] >= 0 && nums[1] <= 59)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");
        }
    }
}
//1- Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the
//numbers are consecutive. For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a
//message: "Consecutive"; otherwise, display "Not Consecutive".
//2- Write a program and ask the user to enter a few numbers separated by a hyphen.If the user simply
//presses Enter, without supplying an input, exit immediately; otherwise, check to see if there are duplicates.If so,
//display "Duplicate" on the console.
//3- Write a program and ask the user to enter a time value in the 24-hour time format(e.g. 19:00). A valid time should be
//between 00:00 and 23:59. If the time is valid, display "Ok"; otherwise, display "Invalid Time". If the user doesn't provide any
//values, consider it as invalid time.
//4- Write a program and ask the user to enter a few words separated by a space.Use the words to create a variable name with PascalCase.
//For example, if the user types: "number of students", display "NumberOfStudents". Make sure that the program is not dependent on the
//input.So, if the user types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
//5- Write a program and ask the user to enter an English word. Count the number of vowels (a, e, o, u, i) in the word. So, if the user enters
//"inadequate", the program should display 6 on the console.
