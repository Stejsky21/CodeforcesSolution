using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program268A
    {
        static void Main268A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var teams = int.Parse(firstLine);
            var result = 0;

            int[] homeDress = new int[teams];
            int[] awayDress = new int[teams];

            for (int i = 0; i < teams; i++)
            {
                var secondLine = Console.ReadLine().Split(' ');
                var teamDressHome = int.Parse(secondLine[0]);
                var teamDressAway = int.Parse(secondLine[1]);

                homeDress[i] = teamDressHome;
                awayDress[i] = teamDressAway;
            }

            for (int i = 0; i < teams; i++)
            {
                for (int j = 0; j < teams; j++)
                {
                    if (homeDress[i] == awayDress[j])
                    {
                        result++;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
