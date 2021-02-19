using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program427A
    {
        static void Main427A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var numberOfEvents = int.Parse(firstLine);

            var secondLine = Console.ReadLine();
            var individualCases = secondLine.Split(' ');

            var result = 0;
            int[] arrayOfCases = new int[numberOfEvents];

            for (int i = 0; i < numberOfEvents; i++)
            {
                arrayOfCases[i] = int.Parse(individualCases[i]);
            }

            Stack<int> officersStack = new Stack<int>();

            for (int i = 0; i < arrayOfCases.Length; i++)
            {
                if (arrayOfCases[i] == -1)
                {
                    if (officersStack.Count >= 1)
                    {
                        officersStack.Pop();
                    }
                    else
                    {
                        result++;
                    }
                }
                else
                {
                    for (int j = 0; j < arrayOfCases[i]; j++)
                    {
                        officersStack.Push(1);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
