﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine();
            var X = int.Parse(firstLine.Split(' ')[0]);
            var Y = int.Parse(firstLine.Split(' ')[1]);
            var result = 0;

            for (int i = 0; i < X; i++)
            {
                var secondLine = Console.ReadLine();
                var fotky = secondLine.Split(' ');

                for (int j = 0; j < Y; j++)
                {
                    if (fotky[j] == "B" || fotky[j] == "W" || fotky[j] == "G")
                    {
                    }
                    else
                    {
                        result++;
                    }
                }
            }

            if (result >= 1)
            {
                Console.WriteLine("#Color");
            }
            else
            {
                Console.WriteLine("#Black&White");
            }
        }
    }
}

