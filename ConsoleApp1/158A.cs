using System;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program158A
    {
        static void Main158A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var n = int.Parse(firstLine.Split(' ')[0]);
            var k = int.Parse(firstLine.Split(' ')[1]);

            var secondLine = Console.ReadLine();
            var scores = secondLine.Split(' ');
            var scoreOfK = int.Parse(scores[k - 1]);
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                if (int.Parse(scores[i]) >= scoreOfK && int.Parse(scores[i]) > 0)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
