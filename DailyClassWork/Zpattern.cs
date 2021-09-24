using System;
using System.Collections.Generic;
using System.Text;

namespace DailyClassWork
{
    class Zpattern
    {
        static void Main(String[] args)
        {
            int i, j;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j < 5; j++)
                {
                    if (i == 1 || i == 5 || i + j == 6)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
