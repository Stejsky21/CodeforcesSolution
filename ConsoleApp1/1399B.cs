using System;
using System.Linq;
using System.Collections.Generic;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program1399B
    {
        static void Main1399B(string[] args)
        {

            var firstLine = Console.ReadLine();
            var exercises = int.Parse(firstLine);
            long result = 0;

            for (int i = 0; i < exercises; i++)
            {
                var secondLine = Console.ReadLine();
                var arrayLenght = int.Parse(secondLine);

                var thirdLine = Console.ReadLine();
                var arrayOneNumbers = thirdLine.Split(' ');

                var fourthLine = Console.ReadLine();
                var arrayTwoNumbers = fourthLine.Split(' ');

                int[] arrayOne = new int[arrayLenght];
                int[] arrayTwo = new int[arrayLenght];

                for (int j = 0; j < arrayLenght; j++)
                {
                    arrayOne[j] = int.Parse(arrayOneNumbers[j]);
                }

                for (int k = 0; k < arrayLenght; k++)
                {
                    arrayTwo[k] = int.Parse(arrayTwoNumbers[k]);
                }

                var minValueInArrayOne = arrayOne.Min();
                var minValueInArrayTwo = arrayTwo.Min();
                var maxValueInArrayOne = arrayOne.Max();
                var maxValueInArrayTwo = arrayTwo.Max();

                for (int l = 0; l < arrayLenght; l++)
                {
                    var a = 0;
                    var b = 0;

                    for (int m = 0; m < maxValueInArrayOne + maxValueInArrayTwo; m++)
                    {
                        if (arrayOne[l] > minValueInArrayOne && arrayTwo[l] > minValueInArrayTwo)
                        {
                            a = arrayOne[l] - minValueInArrayOne;
                            b = arrayTwo[l] - minValueInArrayTwo;
                            if (a < b)
                            {
                                arrayOne[l] = arrayOne[l] - a;
                                arrayTwo[l] = arrayTwo[l] - a;
                                result += a;
                            }
                            else if (a >= b)
                            {
                                arrayOne[l] = arrayOne[l] - b;
                                arrayTwo[l] = arrayTwo[l] - b;
                                result += b;
                            }
                        }
                        else if (arrayOne[l] > minValueInArrayOne && arrayTwo[l] == minValueInArrayTwo)
                        {
                            arrayOne[l] = arrayOne[l] - minValueInArrayOne;
                            result += arrayOne[l];
                            arrayOne[l] = minValueInArrayOne;
                        }
                        else if (arrayTwo[l] > minValueInArrayTwo && arrayOne[l] == minValueInArrayOne)
                        {
                            arrayTwo[l] = arrayTwo[l] - minValueInArrayTwo;
                            result += arrayTwo[l];
                            arrayTwo[l] = minValueInArrayTwo;
                        }
                        else
                        {
                            break;
                        }
                    }
                }

                arrayOne.DefaultIfEmpty();
                arrayTwo.DefaultIfEmpty();
                Console.WriteLine(result);
                result = 0;
            }
        }
    }
}

