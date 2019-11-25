using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Homework1
{
   public class Exercises
    {
        // 1.Write a method that reads from the console three numbers of type int and prints their sum.
        public void Problem1()
        {
            Console.WriteLine("Add the first number");
            string number1 = Console.ReadLine();
            Console.WriteLine("Add the second number");
            string number2 = Console.ReadLine();
            Console.WriteLine("Add the last number");
            string number3 = Console.ReadLine();
            int firstNumber = int.Parse(number1); 
            int secondNumber = int.Parse(number2);
            int lastNumber = int.Parse(number3);
            Console.WriteLine("The sum is: " + (firstNumber + secondNumber + lastNumber));
        }
        //2.Write a method that reads five numbers from the console and prints the greatest of them.
        public void Problem2()
        {
            Console.WriteLine("Write the first number");
            string listofNumbers1 = Console.ReadLine();
            Console.WriteLine("Write the second number");
            string listofNumbers2 = Console.ReadLine();
            Console.WriteLine("Write the third number");
            string listofNumbers3 = Console.ReadLine();
            Console.WriteLine("Write the fourth number");
            string listofNumbers4 = Console.ReadLine();
            Console.WriteLine("Write the fifth number");
            string listofNumbers5 = Console.ReadLine();
            int firstNumber = int.Parse(listofNumbers1);
            int secondNumber = int.Parse(listofNumbers2);
            int thirdNumber = int.Parse(listofNumbers3);
            int fourthNumber = int.Parse(listofNumbers4);
            int fifthNumber = int.Parse(listofNumbers5);
            if(firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
            {
                Console.WriteLine("The greatest number is " + firstNumber);
            } else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
            {
                Console.WriteLine("The greateste number is " + secondNumber);
            } else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
            {
                Console.WriteLine("The greatest number is " + thirdNumber);
            } else if(fourthNumber > fifthNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
            {
                Console.WriteLine("The greatest number is " + fourthNumber);
            } else
            {
                Console.WriteLine("The greatest number is " + fifthNumber);
            }
           
        }
        // 3.Write a method that reads from the console the radius "r" of a circle and prints its perimeter and area.
        public void Problem3()
        {
            double r, Perimeter, Area;//create the variables
            double PI = 3.14;//the same
            Console.WriteLine("Please write the radius of your circle: ");
             r = int.Parse(Console.ReadLine());//pars to numbers
            Perimeter = 2 * PI * r;//write the formula
            Console.WriteLine("The perimeter of your circle is: " + Perimeter);//outputs the result
            Area = PI * Math.Pow(r,2);//write the formula
            Console.WriteLine("The area of your circle is: " + Area);//outputs the result         

        }
        /* 4.Write a method that reads from the console two integer numbers (int) and prints how many numbers
        between them exist that are divisible with 5. such that the remainder of their division by 5 is 0. 
        Example: in the range(14, 25) there are 3 such numbers: 15, 20 and 25.*/

        public void Problem4()
        {
            int number1; int number2; int num; //very important to create the third variable "num"
            Console.WriteLine("Type the range of numbers");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
           for(num = number1; num <= number2; num++)//replace number1 and 2 with num
            {

                if (num % 5 == 0)
                    
                    
                Console.WriteLine("There numbers divisible with 5 are: " + num);
            }
        }
        /*5. Write a method that reads two numbers from the console and prints the greater of them.
        Solve the problem without using conditional statements and with conditional statements.*/

        public void Problem5()
        {
            Console.WriteLine("Please write the first number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Please write the secund number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}", Math.Max(num1, num2), Math.Min(num1,num2));//{0} brings the greater number, max and min for both int
        }
        /*6. Write a method that reads five integer numbers and prints their sum. 
         * If an invalid number is entered the method should prompt the user to enter another number(only once)*/

        public void Problem6()
        {
            int sum = 0;//the sum like a+b+c+d+e      
            
            for(int i = 0; i < 5; i++)//takes only 5 numbers
            {
                Console.WriteLine("Enter a number");
                string input = Console.ReadLine();//reads what is input

                int numbers;
                bool checkParse = int.TryParse(input, out numbers);//parse the input and out the numbers

                if(checkParse == false)///if parsing is not going
                {
                    Console.WriteLine("Not valid. Try again!");
                    i--;
                    continue;
                }
                else//if is going
                {
                    sum += numbers;//sum=sum+numbers
                }
            }
            Console.WriteLine("The sum is: " + sum);//print the sum

        }
        //7. Write a method that prints on the console the numbers from 1 to N.The number N should be read from the standard input.

        public void Problem7()
        {
            Console.WriteLine("Type a number");
            int lenght = int.Parse(Console.ReadLine());
            for (int i = 0; i < lenght; i++)
            {
                Console.WriteLine(i);
            }
        }
        /*8. Write a method that prints on the console the numbers from 1 to N, which are not divisible by 3 and 7 simultaneously.
         * The number N should be read from the standard input.*/

        public void Problem8()
        {
            Console.WriteLine("Type the numbers");
            int lenght = int.Parse(Console.ReadLine());
            for(int i = 1; i < lenght; i++)
            {
                if(i % 3 == 0 || i % 7 == 0)
                {
                    Console.WriteLine(i);
                }
                
            }

        }
        //9. Write a method that reads from the console a series of 5 integers and prints the smallest and largest of them.

        public void Problem9()
        {
            Console.WriteLine("Input first integer:");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input second integer:");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            int num4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Input third integer:");
            int num5 = int.Parse(Console.ReadLine());

            int[] array = { num1, num2, num3, num4, num5 };//put the nums in an array
            Console.WriteLine("Largest of three: " + array.Max());//search the entire array to give max value
            Console.WriteLine("Lowest of three: " + array.Min());//search the entire array to give min value

        }
        /*10. Write method that outputs a triangle made of stars with variable size, depending on an input parameter. 
         * Look at the examples to get   an idea.
        The input comes as a string number, which needs to be parsed to a number.
        The output is a series of lines printed on the console, forming a triangle of variable size.*/
        public void Problem10()
        {
            Console.WriteLine("Input a number: ");
            int num = int.Parse(Console.ReadLine());
            int a, b;//2 int-- one for space & and one for stars
            for (a = 1; a <= num; a++)
            {

                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");//count the stars 
                }
                Console.WriteLine("");//count the spaces
            }
            ///and now the other side
            for (a = num - 1; a >= 0; a--)//a-- because we going backwards 
            {
                for (b = 1; b <= a; b++)
                {
                    Console.Write("*");//use just write to actualy write in orizontal way
                }
                Console.WriteLine("");
            }
        }

        //11* . Write a method that converts a given number from decimal to binary notation (numeral system).
        public void Problem11()
        {
            Console.WriteLine("Type a number");
            int[] array = new int[100];//use array to store multiple values in a single variable---int in this case
            int n = int.Parse(Console.ReadLine());// n the number input
            int i = 0; 
            while (n > 0)
            {
                array[i] = n % 2;//here n % 2..exe 17 % 2 = 1 then array[0] = 1....8 % 2 = 0,,array[1] = 0
                n = n / 2;// n = 16 / 2 = 8
                i++;//from 1 to 1
            }

            for (int j = i - 1; j >= 0; j--)
                Console.Write(array[j]);//print reversed order
        }
        //12*. Write a method that by a given integer N prints the numbers from 1 to N in random order

        public void Problem12()
        {
            Random rdn = new Random();//for random numbers..very important
            int difnum, randomNumber;//2 variables: one for diferent numbers..and one for random numbers
            Console.WriteLine("Write a number");
            int n = int.Parse(Console.ReadLine());//type a number
            int[] array = new int[n];//use array for multiple values in a single variable int
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;//set the conditions if n = 5 then the array will have 5 numbers
            }
            foreach (int i in array)
            {
                randomNumber = rdn.Next(0, n);//give random numbers from zero to n
                difnum = array[i];//different numbers in array
                array[i] = array[randomNumber];//random numbers in array
                array[randomNumber] = difnum;///different numbers in random numbers

            }
            foreach (int i in array) Console.WriteLine(array[i]);//print

        }
        /*13*. A method which iterates the integers from 1 to 50 
        For multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". 
        For numbers which are multiples of both three and five print "FizzBuzz".*/
        public void Problem13()
        {
            Console.WriteLine("Type a number");
            int n = int.Parse(Console.ReadLine());
            int a = 3;
            int b = 5;//2 variables with 3 and 5 as value
            for (int i = 1; i < n; i++)
            {
                string s = "";//empty string

                if (i == a)
                {
                    a = a + 3;//for next multiple
                    s = s + "Fizz";
                }
                if (i == b)
                {
                    b = b + 5;
                    s = s + "Buzz";
                }
                if (s == "")
                    Console.WriteLine(i);//here we print the numbers that are not divisible with 3 and 5
                else
                    Console.WriteLine(s);//here we print the numbers thar are divisible with 3 and 5
            }

        }

        /*14** A given company has name, address, phone number, fax number, web site and manager. 
        The manager has name, surname and phone number. Write a program that reads information about
            the company and its manager and then prints it on the console.*/
        public void Problem14()
        {
            Console.WriteLine("Company name: ");
            string name1 = Console.ReadLine();

            Console.WriteLine("Company address: ");
            string name2 = Console.ReadLine();

            Console.WriteLine("Company phone number: ");
            string name3 = Console.ReadLine();

            Console.WriteLine("Company fax number: ");
            string name4 = Console.ReadLine();

            Console.WriteLine("Company web site");
            string name5 = Console.ReadLine();

            Console.WriteLine("Manager");
            string name6 = Console.ReadLine();

            Console.WriteLine("Manager name: ");
            string name7 = Console.ReadLine();

            Console.WriteLine("Company surname: ");
            string name8 = Console.ReadLine();

            Console.WriteLine("Manager phone number:");
            string name9 = Console.ReadLine();

            Console.WriteLine("Company: {0}", name1);
            Console.WriteLine("Address: {0}", name2);
            Console.WriteLine("Phone number: {0}", name3);
            Console.WriteLine("Fax Number: {0}", name4);
            Console.WriteLine("Website: {0}", name5);
            Console.WriteLine("Manager name: {0}", name7);
            Console.WriteLine("Manager surname: {0}", name8);
            Console.WriteLine("Phone number: {0}", name9);


        }



    }
}
