using System;
using System.Collections.Generic;
using System.Text;

namespace DailyClassWork
{
        class FactorialWithRecursion
        {
            static void Main(String[] args)
            {
                Console.WriteLine("Please enter factorial number");
                int factNumber = Int32.Parse(Console.ReadLine());

                int result = FactorialCalculation(factNumber);
                Console.WriteLine("Result is :{0}", result);
            }
            static int fact = 1;
            private static int FactorialCalculation(int factNumber)
            {
                if (factNumber > 0)
                {
                    fact = factNumber * FactorialCalculation(factNumber - 1);
                }
                return fact;
            }
        }
    }
}

