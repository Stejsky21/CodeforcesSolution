using System;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program50A
    {
        static void Main50A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var inputArray = firstLine.Split(' ');

            var m = inputArray[0];
            var n = inputArray[1];

            var numberM = int.Parse(m);
            var numberN = int.Parse(n);

            var size = numberM * numberN;
            var result = size / 2;

            Console.WriteLine(result);

        }
    }
}
