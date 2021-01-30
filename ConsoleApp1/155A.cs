using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program155A
    {
        static void Main155A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var pocetPrikladu = int.Parse(firstLine);
            var secondLine = Console.ReadLine().Split(' ');
            var aktualneMaximum = int.Parse(secondLine[0]);
            var aktualneMinimum = int.Parse(secondLine[0]);
            var aktualneBodu = 0;
            var maximum = 0;
            var minimum = 0;

            for (int i = 0; i < pocetPrikladu; i++)
            {
                aktualneBodu = int.Parse(secondLine[i]);

                if (aktualneMaximum < aktualneBodu)
                {
                    maximum++;
                    aktualneMaximum = aktualneBodu;
                }
                else if (aktualneMinimum > aktualneBodu)
                {
                    minimum++;
                    aktualneMinimum = aktualneBodu;
                }
            }

            Console.WriteLine(maximum + minimum);
        }
    }
}