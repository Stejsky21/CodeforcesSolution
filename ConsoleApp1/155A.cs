using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program155A
    {
        static void Main155A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var numberOfExamples = int.Parse(firstLine);
            var secondLine = Console.ReadLine().Split(' ');
            var actualMaximum = int.Parse(secondLine[0]);
            var actualMinimum = int.Parse(secondLine[0]);
            var actualPoints = 0;
            var maximum = 0;
            var minimum = 0;

            for (int i = 0; i < numberOfExamples; i++)
            {
                actualPoints = int.Parse(secondLine[i]);

                if (actualMaximum < actualPoints)
                {
                    maximum++;
                    actualMaximum = actualPoints;
                }
                else if (actualMinimum > actualPoints)
                {
                    minimum++;
                    actualMinimum = actualPoints;
                }
            }

            Console.WriteLine(maximum + minimum);
        }
    }
}
