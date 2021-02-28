using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1283A
    {
        static void Main1283A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var examples = int.Parse(firstLine);

            for (int i = 0; i < examples; i++)
            {
                var secondLine = Console.ReadLine();
                var hours = int.Parse(secondLine.Split(' ')[0]);
                var minutes = int.Parse(secondLine.Split(' ')[1]);
                var result = 1440;

                result = result - (hours * 60);
                result = result - minutes;

                Console.WriteLine(result);
            }
        }
    }
}

