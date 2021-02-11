using System;

public class Program
{
    public static void Main()
    {
        var input = Console.ReadLine();
        var friends = int.Parse(input.Split(' ')[0]);
        var bottles = int.Parse(input.Split(' ')[1]);
        var millilitersOfBottles = int.Parse(input.Split(' ')[2]);
        var limes = int.Parse(input.Split(' ')[3]);
        var slicesOfLimes = int.Parse(input.Split(' ')[4]);
        var salt = int.Parse(input.Split(' ')[5]);
        var drinkNeededForToast = int.Parse(input.Split(' ')[6]);
        var saltNeededForToast = int.Parse(input.Split(' ')[7]);

        var millilitersOfAllBottles = bottles * millilitersOfBottles;
        var drinksOnToasts = millilitersOfAllBottles / drinkNeededForToast;
        var limetsOnToasts = limes * slicesOfLimes;
        var saltOnToasts = salt / saltNeededForToast;

        var min1 = drinksOnToasts / friends;
        var min2 = limetsOnToasts / friends;
        var min3 = saltOnToasts / friends;

        if (min1 < min2 && min1 < min3)
        {
            Console.WriteLine(min1);
        }
        else if (min2 < min1 && min2 < min3)
        {
            Console.WriteLine(min2);
        }
        else
        {
            Console.WriteLine(min3);
        }
    }
}
