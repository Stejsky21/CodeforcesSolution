using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstLine = Console.ReadLine();
            var numberOfCompetitors = int.Parse(firstLine);

            var secondLine = Console.ReadLine();
            var numberofPoints = secondLine.Split(' ');

            var maximum = 

            var result = 0;

            for (int i = 0; i < numberOfCompetitors - 1; i++)
            {
                if (int.Parse(numberofPoints[i]) < int.Parse(numberofPoints[i + 1]))
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}



//var year = int.Parse(Console.ReadLine());

//while (true)
//{
//    year++;

//    var stringYear = year.ToString();
//    var distinctNumbers = stringYear.Distinct().Count();

//    if (distinctNumbers == 4)
//    {
//        break;
//    }
//}

//Console.WriteLine(year);



/*var firstLine = Console.ReadLine();
var n = int.Parse(firstLine.Split(' ')[0]);
var m = int.Parse(firstLine.Split(' ')[1]);

var result = string.Empty;

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        if( i % 2 == 0)
        {
            Console.Write("#");
        }
        else
        {
            // 1, 5, 9, 13 ... +4  posldne #
            // 3, 7, 11, 15            prva #
            if (i % 4 == 3)
            {
                if (j == 0)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
            else
            {
                if (j == n - 1)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(".");
                }
            }
        }
    }

    Console.WriteLine();
}*/