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
            var people = int.Parse(firstLine.Split(' ')[0]);
            var pens = int.Parse(firstLine.Split(' ')[1]);
            var notebooks = int.Parse(firstLine.Split(' ')[2]);

            if(people <= pens && people <= notebooks)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}

