using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program32B
    {
        static void Main32B(string[] args)
        {
            var firstLine = Console.ReadLine();
            var result = "";

            for (int i = 0; i < firstLine.Length; i++)
            {
                if (firstLine[i] == '.')
                {
                    result = result + '0';

                }
                else if (firstLine[i] == '-' && firstLine[i + 1] == '.')
                {
                    result = result + '1';
                    i++;
                }
                else
                {
                    result = result + '2';
                    i++;
                }
            }

            Console.WriteLine(result);
        }
    }
}

