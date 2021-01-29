using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program271A
    {
        static void Main271A(string[] args)
        {
            var year = int.Parse(Console.ReadLine());

            while (true)
            {
                year++;

                var stringYear = year.ToString();
                var distinctNumbers = stringYear.Distinct().Count();

                if (distinctNumbers == 4)
                {
                    break;
                }
            }

            Console.WriteLine(year);
        }
    }
}