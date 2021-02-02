using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1328A
    {
        static void Main1328A(string[] args)
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