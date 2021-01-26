using System;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program263A
    {
        static void Main263A(string[] args)
        {
            var matice = new int[5, 5];
            var result = 0;

            for (int i = 0; i < 5; i++)
            {
                var firstLine = Console.ReadLine().Trim();
                var array = firstLine.Split(' ');

                for (int j = 0; j < array.Length; j++)
                {
                    var hodnotaVPoliNaItePozici = array[j];
                    var cislo = int.Parse(hodnotaVPoliNaItePozici);
                    matice[i, j] = cislo;

                    if (cislo == 1)
                    {
                        var posunStlpcov = j - 2;

                        if (posunStlpcov < 0)
                        {
                            posunStlpcov = -1 * posunStlpcov;
                        }

                        var posunRiadkov = i - 2;

                        if (posunRiadkov < 0)
                        {
                            posunRiadkov = -1 * posunRiadkov;
                        }

                        result = posunRiadkov + posunStlpcov;

                    }
                }
            }

            Console.WriteLine(result);

        }
    }
}