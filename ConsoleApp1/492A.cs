using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program492A
    {
        static void Main492A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var cubes = int.Parse(firstLine);
            var result = 0;
            var count = 0;
            var count2 = 0;
            var pyramidRows = 0;

            for (int i = 0; i < cubes + 1; i++)
            {
                result = result + 1;
                count = count + result;
                count2 = count2 + count;
                pyramidRows++;

                if (count2 > cubes)
                {
                    Console.WriteLine(pyramidRows - 1);
                    break;
                }
            }
        }
    }
}


