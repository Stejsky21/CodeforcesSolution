using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program705A
    {
        static void Main705A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var vrstva = int.Parse(firstLine);
            var result = "";

            for (int i = 0; i < vrstva; i++)
            {
                if (i > 0)
                {
                    result = result + " that ";
                }
                if (i % 2 == 0)
                {
                    result = result + "I hate";
                }
                else
                {
                    result = result + "I love";
                }
            }

            result = result + " it";
            Console.WriteLine(result);
        }
    }
}

