using System;
using System.Linq;

namespace ConsoleApp1
{
    //class Program
    //{
    //static void Main(string[] args)
    class Program750A
    {
        static void Main750A(string[] args)
        {
            var firstLine = Console.ReadLine();
            var exercises = int.Parse(firstLine.Split(' ')[0]);
            var travelMinutes = int.Parse(firstLine.Split(' ')[1]);
            var result = 0;
            var minutesPerOneExercises = 5;
            var minutesPerAllExercises = 5;

            for (int i = 0; i < exercises; i++)
            {
                if (minutesPerAllExercises + travelMinutes <= 240)
                {
                    result++;
                    minutesPerOneExercises += 5;
                    minutesPerAllExercises = minutesPerOneExercises + minutesPerAllExercises;
                }
            }

            Console.WriteLine(result);
        }
    }
}
