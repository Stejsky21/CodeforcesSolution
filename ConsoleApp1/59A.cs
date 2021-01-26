using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program59A
    {
        static void Main59A(string[] args)
        {
            var vstupniSlovo = Console.ReadLine();
            var velkaPismena = 0;
            var malaPismena = 0;

            foreach (char pismeno in vstupniSlovo)

            {
                if (char.IsUpper(pismeno))
                {
                    velkaPismena++;
                }
                else
                {
                    malaPismena++;

                }
            }

            if (velkaPismena > malaPismena)
            {
                Console.WriteLine(vstupniSlovo.ToUpper());
            }
            else
            {
                Console.WriteLine(vstupniSlovo.ToLower());
            }
        }
    }
}
