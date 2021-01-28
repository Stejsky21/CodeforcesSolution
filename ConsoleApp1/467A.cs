using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program467A
    {
        static void Main467A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var numberOfRooms = int.Parse(firstLine);
            var result = 0;

            for (int i = 0; i < numberOfRooms; i++)
            {
                var secondLine = Console.ReadLine();
                var peopleInRooms = int.Parse(secondLine.Split()[0]);
                var capacityOfRooms = int.Parse(secondLine.Split()[1]);

                if (peopleInRooms + 1 < capacityOfRooms)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}


