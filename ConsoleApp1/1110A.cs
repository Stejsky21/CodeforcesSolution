using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1110A
    {
        static void Main1110A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var b = int.Parse(firstLine.Split(' ')[0]);
            var k = int.Parse(firstLine.Split(' ')[1]);

            var secondLine = Console.ReadLine().Split(' ');
            int[] arrayN = new int[k];

            var result = 0;
            var result2 = 0;
            var result3 = 0;

            for (int i = 0; i < k; i++)
            {
                arrayN[i] = int.Parse(secondLine[i]);
            }

            for (int i = 0; i < arrayN.Length - 1; i++)
            {
                result = arrayN[i] * b;
                result2 = result2 + result;
            }

            result3 = result2 + arrayN[k - 1];

            if (result3 % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {
                Console.WriteLine("odd");
            }
        }
    }
}


