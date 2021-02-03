using System;

namespace HelloWorld
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program41A
    {
        static void Main41A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var secondLine = Console.ReadLine();

            var array = new char[secondLine.Length];
            for (int i = secondLine.Length; i > 0; i--)
                array[secondLine.Length - i] = secondLine[i - 1];

            var reversed = new string(array);

            if (firstLine == reversed)
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
