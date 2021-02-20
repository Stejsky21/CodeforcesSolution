using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program702A
    {
        static void Main702A(string[] args)
        {

            var firstLine = Console.ReadLine();
            var examples = int.Parse(firstLine);

            var secondLine = Console.ReadLine();
            var individualExamples = secondLine.Split(' ');
            var maximum = 0;
            var currentResult = 1;

            int[] arrayExamples = new int[examples + 1];

            for (int i = 0; i < examples; i++)
            {
                arrayExamples[i] = int.Parse(individualExamples[i]);
            }

            for (int i = 0; i < examples; i++)
            {
                if (arrayExamples[i] < arrayExamples[i + 1])
                {
                    currentResult++;
                }
                else
                {
                    if (currentResult > maximum)
                    {
                        maximum = currentResult;
                        currentResult = 1;
                    }
                    else
                    {
                        currentResult = 1;
                    }
                }
            }

            Console.WriteLine(maximum);
        }
    }
}

