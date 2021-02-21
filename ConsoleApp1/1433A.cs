using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1433A
    {
        static void Main1433A(string[] args)
        {

            var firstLine = Console.ReadLine();
            var examples = int.Parse(firstLine);
            var p = 0;

        startHere:
            for (var i = p; p < examples; p++)
            {
                var secondLine = Console.ReadLine();
                var number = int.Parse(secondLine);
                var count = 0;

                for (int j = 1; j <= 10; j++)
                {
                    var result = 0;
                    var count1 = 0;

                    for (int k = 0; k < 4; k++)
                    {
                        if (result != number)
                        {
                            result = (result * 10) + j;
                            count1 = count1 + 1;
                            count = count + count1;

                            if (result == number)
                            {
                                Console.WriteLine(count);
                                goto here;
                            }
                        }
                    }
                }

            here:
                if (p == examples - 1)
                {
                    return;
                }
                else
                {
                    p++;
                    goto startHere;
                }
            }
        }
    }
}

