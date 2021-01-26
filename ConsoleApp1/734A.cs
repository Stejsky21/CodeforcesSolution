using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program734A
    {
        static void Main734A(string[] args)
        {
            var pocetHer = Console.ReadLine();
            var vysledkyZHer = Console.ReadLine();
            var AntonovoSkore = 0;
            var DanikovoSkore = 0;

            foreach (var pismeno in vysledkyZHer)
            {
                if (pismeno == 'A')
                {
                    AntonovoSkore++;
                }
                else
                {
                    DanikovoSkore++;
                }
            }

            if (AntonovoSkore > DanikovoSkore)
            {
                Console.WriteLine($"Anton");
            }
            else if (AntonovoSkore < DanikovoSkore)
            {
                Console.WriteLine($"Danik");
            }
            else
            {
                Console.WriteLine($"Friendship");
            }
        }
    }
}