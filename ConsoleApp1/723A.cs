using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program723A
    {
        static void Main723A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var distance = firstLine.Split(' ');

            int[] Array = new int[3];

            for (int i = 0; i < distance.Length; i++)
            {
                Array[i] = int.Parse(distance[i]);
            }

            int maxValue = Array.Max();
            int minValue = Array.Min();

            Console.WriteLine(maxValue - minValue);

        }
    }
}
