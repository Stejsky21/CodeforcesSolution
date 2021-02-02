using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program443A
    {
        static void Main443A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var abeceda = "abcdefghijklmnopqrstuvwxyz";
            var result = 0;

            foreach (var characterInAbeceda in abeceda)
            {
                foreach (var inputCharacter in firstLine.ToLower())
                {
                    if (inputCharacter == characterInAbeceda)
                    {
                        result++;
                        break;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}