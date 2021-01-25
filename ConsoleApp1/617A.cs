using System;

namespace ConsoleApp1
{
    //class Program
    //{
    //   static void Main(string[] args)
    class Program617A
    {
        static void Main617A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var vzdalenostKamarada = int.Parse(firstLine);
            var result = 0;

            for (int i = 0; i < vzdalenostKamarada; i++)
            {
                if (vzdalenostKamarada % 5 == 0)
                {
                    result = vzdalenostKamarada / 5;
                }
                else
                {
                    result = (vzdalenostKamarada / 5) + 1;
                }
            }

            Console.WriteLine(result);
        }
    }

}
