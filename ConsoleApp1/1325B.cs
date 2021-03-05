using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1325B
    {
        static void Main1325B(string[] args)
        {
            var firstLine = Console.ReadLine();
            var exercises = int.Parse(firstLine);

            for (int i = 0; i < exercises; i++)
            {
                var secondLine = Console.ReadLine();
                var arrayLenght = int.Parse(secondLine);
                var thirdLine = Console.ReadLine().Split(' ');
                var arrayNumbers = thirdLine;

                int[] newArray = new int[arrayLenght];

                for (int j = 0; j < arrayLenght; j++)
                {
                    newArray[j] = int.Parse(arrayNumbers[j]);
                }

                int[] arrayWithoutDuplicate = newArray.Distinct().ToArray();

                Console.WriteLine(arrayWithoutDuplicate.Length);
            }
        }
    }
}

