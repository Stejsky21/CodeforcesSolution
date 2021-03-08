using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1337A
    {
        static void Main1337A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var exercises = int.Parse(firstLine);

            for (int i = 0; i < exercises; i++)
            {
                var secondLine = Console.ReadLine();
                var a = int.Parse(secondLine.Split(' ')[0]);
                var b = int.Parse(secondLine.Split(' ')[1]);
                var c = int.Parse(secondLine.Split(' ')[2]);
                var d = int.Parse(secondLine.Split(' ')[3]);

                var x = b;
                var y = c;
                var z = c;

                Console.WriteLine(x + " " + y + " " + z);
            }
        }
    }
}


