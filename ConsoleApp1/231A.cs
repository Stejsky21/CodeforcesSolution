using System;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program231A
    {
        static void Main231A(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                var numbers = Console.ReadLine();
                var petya = numbers[0];
                var vasys = numbers[2];
                var tonya = numbers[4];

                var numberOfSurePeople = 0;

                if (petya == '1')
                {
                    numberOfSurePeople++;
                }

                if (vasys == '1')
                {
                    numberOfSurePeople++;
                }

                if (tonya == '1')
                {
                    numberOfSurePeople++;
                }

                if (numberOfSurePeople >= 2)
                {
                    result++;
                }
            }

            Console.WriteLine(result);
        }
    }
}
