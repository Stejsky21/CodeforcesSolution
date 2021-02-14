using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program144A
    {
        static void Main144A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var numberOfSoldiers = int.Parse(firstLine);

            var secondLine = Console.ReadLine();
            var sizeOfSoldiers = secondLine.Split(' ');

            var resultMax = 0;
            var resultMin = 0;

            int[] rowOfSoldiers = new int[numberOfSoldiers];

            for (int i = 0; i < numberOfSoldiers; i++)
            {
                rowOfSoldiers[i] = int.Parse(sizeOfSoldiers[i]);
            }

            int maxValue = rowOfSoldiers.Max();
            int minValue = rowOfSoldiers.Min();

            for (int j = 0; j < numberOfSoldiers; j++)
            {
                if (rowOfSoldiers[j] == maxValue)
                {
                    break;
                }
                else
                {
                    resultMax++;
                }
            }

            for (int k = numberOfSoldiers; k > 0; k--)
            {
                if (rowOfSoldiers[k - 1] == minValue)
                {
                    break;
                }
                else
                {
                    resultMin++;
                }
            }

            var numberOfMoves = resultMax + resultMin;

            if (numberOfMoves >= numberOfSoldiers)
            {
                Console.WriteLine(numberOfMoves - 1);
            }
            else
            {
                Console.WriteLine(numberOfMoves);
            }
        }
    }
}