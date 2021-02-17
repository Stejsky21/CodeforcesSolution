using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program758A
    {
        static void Main758A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var numberOfCitizens = int.Parse(firstLine);

            var secondLine = Console.ReadLine();
            var welfareOfCitizens = secondLine.Split(' ');

            int[] arrayOfWelfare = new int[numberOfCitizens];

            for (int i = 0; i < numberOfCitizens; i++)
            {
                arrayOfWelfare[i] = int.Parse(welfareOfCitizens[i]);
            }

            var maxValue = arrayOfWelfare.Max();
            var result = 0;

            for (int j = 0; j < numberOfCitizens; j++)
            {
                result += maxValue - arrayOfWelfare[j];
            }

            Console.WriteLine(result);
        }
    }
}
