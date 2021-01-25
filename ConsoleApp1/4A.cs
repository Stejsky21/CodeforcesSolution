using System;

namespace ConsoleApp1
{
   // class Program
   // {
   //     static void Main(string[] args)
    class Program4A
    {
        public static void Main4A(string[] args)
        {
            var weight = int.Parse(Console.ReadLine());

            if (weight % 2 == 0 && weight > 2)
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
