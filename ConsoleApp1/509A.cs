using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program509A
    {
        static void Main509A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var matrixSize = int.Parse(firstLine);
            var result = 0;
            int[,] matrix = new int[matrixSize, matrixSize];

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            for (int i = 0; i < matrixSize - 1; i++)
            {
                for (int j = 1; j < matrixSize; j++)
                {
                    matrix[i + 1, j] = matrix[i, j] + matrix[i + 1, j - 1];
                }
            }

            result = matrix[matrixSize - 1, matrixSize - 1];
            Console.WriteLine(result);
        }
    }
}

