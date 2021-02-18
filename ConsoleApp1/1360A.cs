using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1360A
    {
        static void Main1360A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var exercises = int.Parse(firstLine);
            var square = 0;

            for (int i = 0; i < exercises; i++)
            {
                var secondLine = Console.ReadLine().Split(' ');
                var a = int.Parse(secondLine[0]);
                var b = int.Parse(secondLine[1]);

                if (a > b)
                {
                    if (a / 2 < b)
                    {
                        square = (b * 2) * (b * 2);
                    }
                    else
                    {
                        square = a * a;
                    }
                }
                else if (b > a)
                {
                    if (b / 2 < a)
                    {
                        square = (a * 2) * (a * 2);
                    }
                    else
                    {
                        square = b * b;
                    }
                }
                else
                {
                    square = (a * a) * 4;
                }

                Console.WriteLine(square);
            }
        }
    }
}
