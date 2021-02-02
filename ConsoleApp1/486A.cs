using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program486A
    {
        static void Main486A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var n = long.Parse(firstLine);
            long result = 0;

            if (n % 2 == 0)
            {
                result = n / 2;
            }
            else

            {
                result = (n + 1) / 2 * -1;
            }

            Console.WriteLine(result);
        }
    }
}