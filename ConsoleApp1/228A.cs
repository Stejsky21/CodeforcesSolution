using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program228A
    {
        static void Main228A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var color1 = firstLine.Split(' ')[0];
            var color2 = firstLine.Split(' ')[1];
            var color3 = firstLine.Split(' ')[2];
            var color4 = firstLine.Split(' ')[3];

            var result = 0;

            if (color1 == color2 || color1 == color3 || color1 == color4)
            {
                result++;
            }
            if (color2 == color3 || color2 == color4)
            {
                result++;
            }
            if (color3 == color4)
            {
                result++;
            }
            Console.WriteLine(result);
        }
    }
}
