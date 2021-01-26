using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program785A
    {
        static void Main785A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var pocetKostek = int.Parse(firstLine);
            var Tetrahedron = "Tetrahedron";
            var Cube = "Cube";
            var Octahedron = "Octahedron";
            var Dodecahedron = "Dodecahedron";
            var result = 0;

            for (int i = 0; i < pocetKostek; i++)
            {
                var kostka = Console.ReadLine();

                if (kostka == Tetrahedron)
                {
                    result = result + 4;
                }
                else if (kostka == Cube)
                {
                    result = result + 6;
                }
                else if (kostka == Octahedron)
                {
                    result = result + 8;
                }
                else if (kostka == Dodecahedron)
                {
                    result = result + 12;
                }
                else
                {
                    result = result + 20;
                }
            }

            Console.WriteLine(result);

        }
    }
}

