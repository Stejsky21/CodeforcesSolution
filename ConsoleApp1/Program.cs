﻿using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine();
            var NumberOfExamples = int.Parse(firstLine);

            for (int i = 0; i < NumberOfExamples; i++)
            {
                var secondLine = Console.ReadLine();
                var a = double.Parse(secondLine.Split(' ')[0]);
                var b = double.Parse(secondLine.Split(' ')[1]);

                var remainder = a % b;

                if (remainder == 0)
                {
                    Console.WriteLine(remainder);
                }
                else
                {
                    Console.WriteLine(b - remainder);
                }
            }
        }
    }
}


/*using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine();
            var n = long.Parse(firstLine);
            long result = 0;

            if (n % 2 == 0)
            {
                result = n / 2;
            }
            else
            
            {
                result = (n + 1) / 2 * -1;
            }

            Console.WriteLine(result);
        }
    }
}

/* 4 2
 * 5 -3
 * 6 3
 * 7 -4
 * 8 4
 * 
 */