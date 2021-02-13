using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program148A
    {
        static void Main148A(string[] args)
        {
            var panHit = int.Parse(Console.ReadLine().Split()[0]);
            var closedTail = int.Parse(Console.ReadLine().Split()[0]);
            var stepOnTail = int.Parse(Console.ReadLine().Split()[0]);
            var threats = int.Parse(Console.ReadLine().Split()[0]);
            var totalNumbersOfDrake = int.Parse(Console.ReadLine().Split()[0]);

            var result = 0;
            var DrakeWithoutPain = 0;

            int[] poleDraku = new int[totalNumbersOfDrake];

            for (int i = 0; i < totalNumbersOfDrake; i++)
            {
                poleDraku[i] = i + 1;
            }
            for (int j = panHit - 1; j < poleDraku.Length;)
            {
                poleDraku[j] = 0;
                j += panHit;
            }
            for (int k = closedTail - 1; k < poleDraku.Length;)
            {
                poleDraku[k] = 0;
                k += closedTail;
            }
            for (int l = stepOnTail - 1; l < poleDraku.Length;)
            {
                poleDraku[l] = 0;
                l += stepOnTail;
            }
            for (int m = threats - 1; m < poleDraku.Length;)
            {
                poleDraku[m] = 0;
                m += threats;
            }
            for (int n = 0; n < poleDraku.Length; n++)
            {
                if (poleDraku[n] > 0)
                {
                    result++;
                }
            }

            DrakeWithoutPain = totalNumbersOfDrake - result;

            Console.WriteLine(DrakeWithoutPain);
        }
    }
}