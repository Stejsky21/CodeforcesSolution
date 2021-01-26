using System;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program112A
    {
        static void Main112A(string[] args)
        {
            var first1 = Console.ReadLine();
            var second2 = Console.ReadLine();

            var first = first1.ToLower();
            var second = second2.ToLower();

            if (first.CompareTo(second) == 0)
            {
                Console.WriteLine("0");
            }
            if (first.CompareTo(second) > 0)
            {
                Console.WriteLine("1");
            }
            if (first.CompareTo(second) < 0)
            {
                Console.WriteLine("-1");
            }
        }




    }
}