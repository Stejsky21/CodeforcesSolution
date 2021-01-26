using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
        class Program339A
        {
            static void Main339A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var input = firstLine.Split('+');
            Array.Sort(input);
            var result = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (i > 0)
                {
                    result = result + "+";
                }

                result = result + input[i];
            }

            Console.WriteLine(result);
        }
    }
}

