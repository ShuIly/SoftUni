using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var buyers = new Dictionary<string, IBuyer>();

        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; ++i)
        {
            string[] inputArgs = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (inputArgs.Length == 4)
            {
                buyers.Add(inputArgs[0], new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2], inputArgs[3]));
            }
            else
            {
                buyers.Add(inputArgs[0], new Rebel(inputArgs[0], int.Parse(inputArgs[1])));
            }
        }

        while (true)
        {
            string name = Console.ReadLine();
            if (name == "End")
            {
                break;
            }

            if (buyers.ContainsKey(name))
            {
                buyers[name].BuyFood();
            }
        }

        Console.WriteLine(buyers.Values.Sum(b => b.FoodBought));
    }
}
