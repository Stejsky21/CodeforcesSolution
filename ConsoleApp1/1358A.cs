using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1358A
    {
        static void Main1358A(string[] args)
        {

            var firstLine = Console.ReadLine();
            var exercises = int.Parse(firstLine);

            for (int i = 0; i < exercises; i++)
            {
                int result = 0;
                var secondLine = Console.ReadLine();
                var parkSizeX = int.Parse(secondLine.Split(' ')[0]);
                var parkSizeY = int.Parse(secondLine.Split(' ')[1]);

                if (parkSizeX * parkSizeY % 2 == 0)
                {
                    result = (parkSizeX * parkSizeY) / 2;
                    Console.WriteLine(result);
                }
                else
                {
                    result = (parkSizeX * parkSizeY) / 2;
                    Console.WriteLine(result + 1);
                }
            }
        }
    }
}

