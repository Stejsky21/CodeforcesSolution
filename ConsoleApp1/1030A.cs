using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1030A
    {
        static void Main1030A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var pocetTazanychLidi = int.Parse(firstLine);

            var secondLine = Console.ReadLine();
            var odpovedi = secondLine.Split(' ');
            var resulthard = 0;

            for (int i = 0; i < pocetTazanychLidi; i++)
            {
                if (int.Parse(odpovedi[i]) == 1)
                {
                    resulthard++;
                }
            }

            if (resulthard > 0)
            {
                Console.WriteLine($"HARD");
            }
            else
            {
                Console.WriteLine($"EASY");
            }
        }
    }
}