using System;
using System.Collections.Generic;
using System.Text;

namespace DailyClassWork
{
    class Factorial
    {
        static void Main(String[] args)
        {
            Console.WriteLine("please provide factorial number");
            int FactNumber = Int32.Parse(Console.ReadLine());
            int FactResult = 1;

            //for ex-5!=1*2*3*4*5
            for (int i = 1; i <= FactNumber; i++)
            {
                FactResult = FactResult * i;
            }
            Console.WriteLine("{0}! is {1}", FactNumber, FactResult);
        }
    }
}
   
