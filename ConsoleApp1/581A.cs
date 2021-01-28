using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program581A
    {
        static void Main581A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var redSocks = int.Parse(firstLine.Split(' ')[0]);
            var blueSocks = int.Parse(firstLine.Split(' ')[1]);
            var overallRedSocks = redSocks;
            var overallBlueSocks = blueSocks;
            var overallSocks = (redSocks + blueSocks) / 2;

            var differentSocks = 0;
            var sameSocks = 0;

            for (int i = 0; i < overallSocks; i++)
            {
                if (overallRedSocks > 0 && overallBlueSocks > 0)
                {
                    differentSocks++;
                    overallBlueSocks--;
                    overallRedSocks--;
                }
                else
                {
                    sameSocks++;
                    overallRedSocks--;
                    overallBlueSocks--;
                }
            }

            Console.Write(differentSocks + " " + sameSocks);
        }
    }
}


