using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program791A
    {
        static void Main791A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var Limak = int.Parse(firstLine.Split(' ')[0]);
            var Bob = int.Parse(firstLine.Split(' ')[1]);
            var years = 0;

            while (Limak <= Bob)
            {
                Limak = (Limak * 3);
                Bob = (Bob * 2);
                years++;
            }

            Console.WriteLine(years);

        }
    }
}