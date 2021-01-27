using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program266B
    {
        static void Main266B(string[] args)
        {
            var firstLine = Console.ReadLine();
            var numberOfPeople = int.Parse(firstLine.Split(' ')[0]);
            var numberOfRepetitions = int.Parse(firstLine.Split(' ')[1]);

            var queue = Console.ReadLine();

            for (int k = 0; k < numberOfRepetitions; k++)
            {
                for (int i = 0; i < numberOfPeople - 1; i++)
                {
                    if (queue[i] == 'B' && queue[i + 1] == 'G')
                    {
                        var newQueue = string.Empty;

                        for (int j = 0; j < numberOfPeople; j++)
                        {
                            if (i == j)
                            {
                                newQueue += queue[i + 1];
                                newQueue += queue[i];
                                j++;
                            }
                            else
                            {
                                newQueue += queue[j];
                            }
                        }
                        queue = newQueue;
                        i++;
                    }
                }
            }

            Console.WriteLine(queue);
        }
    }
}

