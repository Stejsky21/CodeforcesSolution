using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program510A
    {
        static void Main510A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var n = int.Parse(firstLine.Split(' ')[0]);
            var m = int.Parse(firstLine.Split(' ')[1]);

            var result = string.Empty;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i % 2 == 0)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        if (i % 4 == 3)
                        {
                            if (j == 0)
                            {
                                Console.Write("#");
                            }
                            else
                            {
                                Console.Write(".");
                            }
                        }
                        else
                        {
                            if (j == m - 1)
                            {
                                Console.Write("#");
                            }
                            else
                            {
                                Console.Write(".");
                            }
                        }
                    }
                }

                Console.WriteLine();
            }
        }
    }
}