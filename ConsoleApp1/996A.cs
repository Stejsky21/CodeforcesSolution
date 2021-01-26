using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program996A
    {
        static void Main996A(string[] args)
        {
            var firstLine = int.Parse(Console.ReadLine());
            var cash = firstLine;
            var result = 0;

            for (int i = 0; i < cash;)
            {
                if (cash >= 100)
                {
                    cash = cash - 100;
                    result++;
                }
                else if (cash >= 20)
                {
                    cash = cash - 20;
                    result++;
                }
                else if (cash >= 10)
                {
                    cash = cash - 10;
                    result++;
                }
                else if (cash >= 5)
                {
                    cash = cash - 5;
                    result++;
                }
                else
                {
                    cash = cash - 1;
                    result++;
                }
            }

            Console.WriteLine(result);

        }
    }
}

