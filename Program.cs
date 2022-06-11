using CsharpPart1.Math;
//using CsharpPart1.Exercises;
using System;

namespace CsharpPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex1 = new ExercisesText();
            ex1.TextFive();

           // Console.WriteLine("Hello World!");
            //var calcDemo = new Calculator();

            //int[] numbers = new int[3]; // Fixed
            //int[] nums = new int[3] { 1, 2, 3 }; // Initialized  // better to use var

            //var verbatumStr = @"Hi John,de/"; // This does add the tabs in :'(
            //Console.WriteLine(verbatumStr);

        }
    }
    // Comment single line, don't use multi live with /*   */

    // Static Modifier, like static void Main() only 1 instance where you can access the method

    // Classes are only created at the namespace level

    // Classes vs Struct. Use struct only when its called thousands of times and for small values i.e. rgb/ point x y. Struct is more efficient


}