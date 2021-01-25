using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //  static void Main(string[] args)
    class Program116A
    {
        static void Main116A(string[] args)
        {
            var stops = int.Parse(Console.ReadLine());
            var maximum = 0;
            var currentNumberOfPeople = 0;

            for (int i = 0; i < stops; i++)
            {
                var numbersOfPeople = Console.ReadLine().Split(' ');
                currentNumberOfPeople -= int.Parse(numbersOfPeople[0]);
                currentNumberOfPeople += int.Parse(numbersOfPeople[1]);

                if (currentNumberOfPeople > maximum)
                {
                    maximum = currentNumberOfPeople;
                }
            }

            Console.WriteLine(maximum);
        }
    }
}

