using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program200B
    {
        static void Main200B(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] drinks = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();
            double result = 0;

            for (int i = 0; i < n; i++)
            {
                result = result + drinks[i];
            }

            Console.WriteLine(result / n);
        }
    }
}
