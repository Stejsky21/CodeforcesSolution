using System;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program282A
    {
        static void Main282A(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var result = 0;

            for (int i = 0; i < n; i++)
            {
                var operation = Console.ReadLine();

                if (operation == "++X")
                {
                    result++;
                }

                if (operation == "X++")
                {
                    result++;
                }

                if (operation == "X--")
                {
                    result--;
                }

                if (operation == "--X")
                {
                    result--;
                }

            }

            Console.WriteLine(result);
        }
    }
}