using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program110A
    {
        static void Main110A(string[] args)
        {
            var inputNumbers = Console.ReadLine();
            var result = 0;

            for (int i = 0; i < inputNumbers.Length; i++)
            {
                if (inputNumbers[i] == '7' || inputNumbers[i] == '4')
                {
                    result++;
                }
            }
            if (result == 7)
            {
                Console.WriteLine($"YES");
            }
            else if (result == 4)
            {
                Console.WriteLine($"YES");
            }
            else
            {
                Console.WriteLine($"NO");
            }
        }
    }
}