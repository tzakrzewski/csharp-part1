using System;

namespace CsharpPart1
{
    public class ExerciseConditional
    {
        public int UserInput;
        public string UserText;

        public void ConditionalOne()
        {
            Console.WriteLine("Enter in Inputs");
            UserInput = Convert.ToInt32(Console.ReadLine());
            if (UserInput >= 0 && UserInput < 11)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("InValid");
        }

        public void ConditionalTwo()
        {
            Console.WriteLine("Enter in Inputes");
            UserText = Console.ReadLine();

            var splitText = UserText.Split(' ');
            var max = Convert.ToInt32(splitText[0]) > Convert.ToInt32(splitText[1]) ? Convert.ToInt32(splitText[0]) : Convert.ToInt32(splitText[1]);
            Console.WriteLine(max);
        }

        public enum Picture
        {
            Portrait = 1,
            Landscape = 2
        }

        public void ConditionalThree()
        {
            Console.WriteLine("Enter width");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter height");
            var height = Convert.ToInt32(Console.ReadLine());

            var pictureType = width > height ? Picture.Landscape : Picture.Portrait;
            Console.WriteLine(pictureType);
        }

        public void ConditionalFour()
        {
            Console.WriteLine("Enter speed limit");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter car speed");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            var pointPerKMH = 5;
            var demeritPoint = (carSpeed - speedLimit) / pointPerKMH;

            if(speedLimit > carSpeed)
                Console.WriteLine("Ok");
            else
            {
                Console.WriteLine("Demerit points: " + demeritPoint);
                if(demeritPoint > 12)
                    Console.WriteLine("LICENSE SUSPENDED");
            }
        }
    }
    /*
    1- Write a program and ask the user to enter a number. The number should be between 1 to 10. If the user enters a valid number, 
    display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into
    nput boxes need to be validated.)
    
    2- Write a program which takes two numbers from the console and displays the maximum of the two.
    
    3- Write a program and ask the user to enter the width and height of an image. Then tell if the image is landscape or portrait.

    4- Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, etc and focus
    purely on the logic. Write a program that asks the user to enter the speed limit. Once set, the program asks for the speed
    of a car. If the user enters a value less than the speed limit, program should display Ok on the console. If the value is 
    above the speed limit, the program should calculate the number of demerit points. For every 5km/hr above the speed limit,
    1 demerit points should be incurred and displayed on the console. If the number of demerit points is above 12, the program 
    should display License Suspended.
    */
}