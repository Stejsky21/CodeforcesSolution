using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //    static void Main(string[] args)
    class Program977A
    {
        static void Main977A(string[] args)
        {
            var firstLine = Console.ReadLine().Split(' ');
            var number = int.Parse(firstLine[0]);
            var numberOfSubstractions = int.Parse(firstLine[1]);

            for (int i = 0; i < numberOfSubstractions; i++)
            {
                if (number % 10 == 0)
                {
                    number = number / 10;
                }
                else
                {
                    number--;
                }
            }

            Console.WriteLine(number);
        }
    }
}