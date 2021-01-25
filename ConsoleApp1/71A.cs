using System;

namespace ConsoleApp1
{
    //class Program
    //{
    //  static void Main(string[] args)
    class Program71A
    {
        static void Main71A(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();

                if (word.Length > 10)
                {
                    var result = word[0].ToString();
                    //result += word.Length;
                    var wordLength = word.Length - 2;
                    result = result + wordLength;
                    result = result + word[word.Length - 1];
                    Console.WriteLine(result);
                }
                else
                {
                    Console.WriteLine(word);
                }
            }
        }
    }
}
