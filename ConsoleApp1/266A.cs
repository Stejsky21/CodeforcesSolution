using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program266A
    {
        static void Main266A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var pocetKamenu = int.Parse(firstLine);
            var barvyKamenu = Console.ReadLine();
            var result = 0;

            for (int i = 0; i < pocetKamenu - 1; i++)
            {
                if (barvyKamenu[i] == barvyKamenu[i + 1])
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}