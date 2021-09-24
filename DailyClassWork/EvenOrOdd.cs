using System;
using System.Collections.Generic;
using System.Text;

namespace DailyClassWork
{
    //Write a program to find even or odd number without mod and divide operator
    class FindEvenOrOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give any number ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
                Console.WriteLine(number + " is Even Number");
            else
                Console.WriteLine(number + " is Odd Number");

            //without using module divider
            Console.WriteLine("\n Without module and divider operators");
            if (isEven(number))
            {
                Console.WriteLine(number + " is Even Number");
            }
            else
                Console.WriteLine(number + " is Odd Number");
        }
        private static bool isEven(int number)
        {
            bool isEven = true;

            for (int i = 1; i <= number; i++)
                isEven = !isEven;
            return isEven;


        }
    }
}
