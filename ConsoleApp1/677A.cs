using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program677A
    {
        static void Main677A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var pocetPratel = int.Parse(firstLine.Split(' ')[0]);
            var VyskaPlotu = int.Parse(firstLine.Split(' ')[1]);

            var secondLine = Console.ReadLine();
            var vyska = secondLine.Split(' ');
            var result = 0;

            for (int i = 0; i < pocetPratel; i++)
            {
                if (int.Parse(vyska[i]) <= VyskaPlotu)
                {
                    result = result + 1;
                }

                else
                {
                    result = result + 2;
                }
            }

            Console.WriteLine(result);

        }
    }
}