﻿using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var slovo = Console.ReadLine();

            if (slovo.Length == 0)
            {
                Console.WriteLine(char.ToUpper(slovo[0]));
            }
            else
            {
                Console.WriteLine(char.ToUpper(slovo[0]) + slovo.Substring(1));
            }
        }
    }
}
