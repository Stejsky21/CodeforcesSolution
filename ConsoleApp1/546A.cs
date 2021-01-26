using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program546A
    {
        static void Main546A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var cenaBananu = int.Parse(firstLine.Split(' ')[0]);
            var penizeCoMam = int.Parse(firstLine.Split(' ')[1]);
            var pocetBananuCoChiKoupit = int.Parse(firstLine.Split(' ')[2]);
            var celkovaCena = 0;

            for (int i = 1; i <= pocetBananuCoChiKoupit; i++)
            {
                if (pocetBananuCoChiKoupit > 1)
                {
                    celkovaCena += i * cenaBananu;
                }
            }

            var potrebujiPujcit = (celkovaCena - penizeCoMam);

            if (penizeCoMam >= celkovaCena)
            {
                Console.WriteLine("0");
            }
            else
            {
                Console.WriteLine(potrebujiPujcit);
            }
        }
    }
}