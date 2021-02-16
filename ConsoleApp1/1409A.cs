using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1409A
    {
        static void Main1409A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var examples = int.Parse(firstLine);

            for (int i = 0; i < examples; i++)
            {
                var secondLine = Console.ReadLine();
                var firstNumber = int.Parse(secondLine.Split(' ')[0]);
                var secondNumber = int.Parse(secondLine.Split(' ')[1]);
                double result = 0;

                if (firstNumber > secondNumber)
                {
                    result = firstNumber - secondNumber;
                    result = result / 10;

                    if (result % 1 == 0)
                    {
                        Console.WriteLine(result);
                    }
                    else
                    {
                        var result2 = (int)result;
                        Console.WriteLine(result2 + 1);
                    }
                }
                else if (firstNumber < secondNumber)
                {
                    result = secondNumber - firstNumber;
                    result = result / 10;

                    if (result % 1 == 0)
                    {
                        Console.WriteLine(result);
                    }
                    else
                    {
                        var result2 = (int)result;
                        Console.WriteLine(result2 + 1);
                    }
                }
                else
                {
                    Console.WriteLine("0");
                }
            }
        }
    }
}
