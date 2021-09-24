using System;
using System.Collections.Generic;
using System.Text;

namespace DailyClassWork
{
        class Apattern
        {
            static void Main(string[] args)
            {
                int i, j;

                for (i = 1; i <= 5; i++)
                {
                    for (j = 1; j <= 4; j++)
                    {
                        if (j == 1 || j == 4 || i == 1 || i == 3)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();

                }
                Console.ReadLine();
            }
        }


    
}

