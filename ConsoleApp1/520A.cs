using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program520A
    {
        static void Main520A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var abeceda = "abcdefghijklmnopqrstuvwxyz";
            var secondLine = Console.ReadLine();
            var result = 0;

            foreach (var characterInAbeceda in abeceda)
            {
                foreach (var inputCharacter in secondLine.ToLower())
                {
                    if (inputCharacter == characterInAbeceda)
                    {
                        result++;
                        break;
                    }
                }
            }
            if (result >= 26)
            {
                Console.WriteLine($"YES");
            }
            else
            {
                Console.WriteLine($"NO");
            }
        }
    }
}