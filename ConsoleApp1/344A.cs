using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program344A
    {
        static void Main344A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var numbersOfMagnets = int.Parse(firstLine);
            var group = 0;
            var result = 0;

            for (int i = 0; i < numbersOfMagnets; i++)
            {
                var secondLine = Console.ReadLine();
                var magnets = int.Parse(secondLine);

                if (magnets == result)
                {

                }
                else
                {
                    group++;
                }
                result = magnets;
            }
            Console.WriteLine(group);
        }
    }
}