using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1335A
    {
        static void Main1335A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var examples = int.Parse(firstLine);

            for (int i = 0; i < examples; i++)
            {
                var number = int.Parse(Console.ReadLine().Split()[0]);

                var result = number / 2;

                if (number <= 2)
                {
                    Console.WriteLine("0");
                }
                else if (number % 2 == 0)
                {
                    Console.WriteLine(result - 1);
                }
                else
                {
                    Console.WriteLine(result);
                }
            }
        }
    }
}