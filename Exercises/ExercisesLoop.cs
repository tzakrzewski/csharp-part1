using System;
using System.Collections.Generic;
using System.Text;

namespace CsharpPart1
{
    class ExercisesLoop
    {
        public void LoopOne()
        {
            var numsDivisibleByThreeCount = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                    numsDivisibleByThreeCount++;
            }
            Console.WriteLine("Total nums divisible by 3: " + numsDivisibleByThreeCount);
        }

        public void LoopTwo()
        {
            var totalInput = 0;
            var terminatingString = "ok";

            while (true)
            {
                Console.WriteLine("Enter Input: ");
                var input = Console.ReadLine();

                if (input == terminatingString)
                    break;

                totalInput += Convert.ToInt32(input);
            }
            Console.WriteLine(totalInput);
        }

        public void LoopThree()
        {
            Console.WriteLine("Enter Input");
            var input = Convert.ToInt32(Console.ReadLine());
            var factorial = 1;

            for(var i = input; i > 1; i--)
                factorial *= i;
            
            Console.WriteLine(String.Format("{0}! = {1}", input, factorial));
        }

        public void LoopFour()
        {
            Console.WriteLine("Guess the number! : ");

            var guesses = 4;
            var userGuess = 0;
            var random = new Random();
            var randomNum = random.Next(1, 10);

            for(var i = guesses; i > 0; i--)
            {
                userGuess = Convert.ToInt32(Console.ReadLine());
                if (userGuess == randomNum)
                {
                    Console.WriteLine("You won");
                    return;
                }
                Console.WriteLine("You lost " + randomNum);
            }
        }

        public void LoopFive()
        {
            Console.Write("Enter commoa separated numbers: ");
            var input = Console.ReadLine();

            var numbers = input.Split(',');

            // Assume the first number is the max 
            var max = Convert.ToInt32(numbers[0]);

            foreach (var str in numbers)
            {
                var number = Convert.ToInt32(str);
                if (number > max)
                    max = number;
            }

            Console.WriteLine("Max is " + max);
        }
    }

//1- Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.Display the count on the console.
//2- Write a program and continuously ask the user to enter a number or "ok" to exit. Calculate the sum of all the previously 
//        entered numbers and display it on the console.
//3- Write a program and ask the user to enter a number.Compute the factorial of the number and prvar it on the console. 
//        For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.
//4- Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.If the user 
//        guesses the number, display “You won"; otherwise, display “You lost". (To make sure the program is behaving correctly, 
//        you can display the secret number on the console first.)
//5- Write a program and ask the user to enter a series of numbers separated by comma.Find the maximum of the numbers and
//    display it on the console.For example, if the user enters “5, 3, 8, 1, 4", the program should display 8.
}
