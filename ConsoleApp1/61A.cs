using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //    static void Main(string[] args)
    class Program61A
    {
        static void Solution61A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine();
            var result = string.Empty;
            for (int i = 0; i < firstLine.Length; i++)
            {
                if (firstLine[i] == secondLine[i])
                {
                    result = result + 0;
                }
                else
                {
                    result = result + 1;
                }
            }

            Console.WriteLine(result);
        }
    }
}

