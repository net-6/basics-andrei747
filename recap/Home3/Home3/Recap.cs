using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Home3
{
    enum Image
    {
        Landscape,
        Portrait
    }
    public class Recap
    {

        //Conditionals
        /// <summary>
        /// Write a program and ask the user to enter a number. 
        /// The number should be between 1 to 10. If the user enters 
        /// a valid number, display "Valid" on the console. 
        /// Otherwise, display "Invalid". (This logic is used a lot in 
        /// applications where values entered into input boxes need to be validated.)
        /// </summary>
        /*public void Problem1()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            if(num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid"); 
            }

        }
        /// <summary>
        /// Write a program which takes two numbers from the console and displays the maximum of the two.
        /// </summary>
        public void Problem2()
        {
            Console.WriteLine("Type first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Type second number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The maximum number is: " + Math.Max(num1, num2));

        }
        /// <summary>
        /// Write a program and ask the user to enter the width and height of an image. Then tell if the image 
        /// is landscape or portrait. Use an enum for in which to group the landscape and portrait orientations
        /// </summary>
        public void Problem3()
        {
            Console.WriteLine("Enter the width of the image");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the heigth of the image");
            int num2 = int.Parse(Console.ReadLine());
            Image img1 = Image.Landscape;
            Image img2 = Image.Portrait;
            if(num1 <= 400 && num2 <= 400)
            {
                Console.WriteLine("The image is: " + img2);
            }
            else
            {
                Console.WriteLine("The image is :" + img1);
            }
        }
        /// <summary>
        /// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors, 
        /// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. Once set, 
        /// the program asks for the speed of a car. If the user enters a value less than the speed limit, program should 
        /// display Ok on the console. If the value is above the speed limit, the program should calculate the number of 
        /// penalty points. For every 5km/hr above the speed limit, 1 penalty point should be incurred and displayed on 
        /// the console. If the number of penalty points is above 12, the program should display License Suspended.
        /// </summary>
        public void Problem4()
        {
            Console.WriteLine("Enter the speed limit");
            int speedLimit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the speed of car");
            int speedofCar = int.Parse(Console.ReadLine());
            int penaltypoints = 0;
            int i = 0;
            if (speedofCar < speedLimit)
            {
                Console.WriteLine("Ok");
            }
            else
            {
               for(int speedofCar1 = speedLimit; speedofCar1 < speedofCar; speedofCar1 = speedofCar + 5)
                    penaltypoints++;
                {
                    
                    Console.WriteLine("You have:"+ penaltypoints+ "penalty points");///in progress
                }
                                                                                                           
            }

        }*/
        //## Lists
        ///<pattern>
        /// 1) John, Mary and 3 others like your post
        /// 2) John and Mary like your post
        /// 3) John likes your post
        /// </pattern>
        ///  <summary>
        /// Write a program and continuously ask the user to enter different names, until the user presses Enter 
        /// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
        /// </summary>
        public void Problem5()
        {
            Console.WriteLine("Enter a name");
            string s1 = Console.ReadLine() +  Console.ReadLine() + Console.ReadLine();
            char [] arr = s1.ToCharArray();
            Console.WriteLine("Enter a name");
            // string s2 = Console.ReadLine() + Console.ReadLine() + Console.ReadLine();
           //in progress
        }
        //in progress for the other 20 problems







    }


}

