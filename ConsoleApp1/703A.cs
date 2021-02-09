using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program703A
    {
        static void Main703A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var numberOfGames = int.Parse(firstLine);
            var mishkaScore = 0;
            var chrisScore = 0;

            for (int i = 0; i < numberOfGames; i++)
            {
                var secondLine = Console.ReadLine();
                var mishkaRoll = int.Parse(secondLine.Split(' ')[0]);
                var chrisRoll = int.Parse(secondLine.Split(' ')[1]);

                if (mishkaRoll > chrisRoll)
                {
                    mishkaScore++;
                }
                else if (mishkaRoll == chrisRoll)
                {
                }
                else
                {
                    chrisScore++;
                }
            }

            if (mishkaScore > chrisScore)
            {
                Console.WriteLine("Mishka");
            }
            else if (mishkaScore == chrisScore)
            {
                Console.WriteLine("Friendship is magic!^^");
            }
            else
            {
                Console.WriteLine("Chris");
            }
        }
    }
}
