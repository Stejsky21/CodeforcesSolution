using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program141A
    {
        static void Main141A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine();
            var thirdLine = Console.ReadLine();

            var result = 0;

            char[] resultArray = new char[thirdLine.Length];
            char[] firstAndSecondArray = new char[firstLine.Length + secondLine.Length];

            for (int i = 0; i < thirdLine.Length; i++)
            {
                resultArray[i] = thirdLine[i];
            }

            for (int j = 0; j < firstLine.Length; j++)
            {
                firstAndSecondArray[j] = firstLine[j];
            }

            for (int k = 0; k < secondLine.Length; k++)
            {
                firstAndSecondArray[k + firstLine.Length] = secondLine[k];
            }

            for (int m = 0; m < firstAndSecondArray.Length; m++)
            {
                for (int n = 0; n < resultArray.Length; n++)
                {

                    if (resultArray[n] == firstAndSecondArray[m])
                    {
                        resultArray[n] = '#';
                        break;
                    }
                }
            }

            for (int o = 0; o < resultArray.Length; o++)
            {
                if (resultArray[o] != '#')
                {
                    result++;
                }
            }

            if (result <= 0 && resultArray.Length == firstAndSecondArray.Length)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
