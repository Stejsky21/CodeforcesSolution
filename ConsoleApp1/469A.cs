using System;
using System.Linq;
using System.Collections;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program469A
    {
        static void Main469A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var levels = int.Parse(firstLine);

            var secondLine = Console.ReadLine().Split(' ');
            var num = int.Parse(secondLine[0]);

            var thirdLine = Console.ReadLine().Split(' ');
            var numberOfLevelPassedLittleX = int.Parse(thirdLine[0]);

            int[] levelsPassedByLittleX = new int[101];
            int[] levelsPassedByLittleY = new int[101];

            var result = 0;

            for (int i = 1; i <= num; i++)
            {
                levelsPassedByLittleX[i - 1] = int.Parse(secondLine[i]);
            }
            for (int j = 1; j <= numberOfLevelPassedLittleX; j++)
            {
                levelsPassedByLittleY[j - 1] = int.Parse(thirdLine[j]);
            }

            var levelsPassedByLittleXY = levelsPassedByLittleX.Union(levelsPassedByLittleY).ToArray();

            for (int k = 1; k <= levels; k++)
            {
                for (int l = 0; l < levelsPassedByLittleXY.Length; l++)
                {
                    if (k == levelsPassedByLittleXY[l])
                    {
                        result++;
                        break;
                    }
                }
            }
            if (result == levels)
            {
                Console.WriteLine("I become the guy.");
            }
            else
            {
                Console.WriteLine("Oh, my keyboard!");
            }
        }
    }
}
