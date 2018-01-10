using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<IBirthable> birthables = new List<IBirthable>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] inputArgs = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            switch (inputArgs[0])
            {
                case "Citizen":
                    birthables.Add(new Citizen(inputArgs[1], int.Parse(inputArgs[2]), inputArgs[3], inputArgs[4]));
                    break;
                case "Pet":
                    birthables.Add(new Pet(inputArgs[1], inputArgs[2]));
                    break;
            }
        }

        string year = Console.ReadLine();
        foreach (string birthDate in birthables
            .Select(b => b.BirthDate)
            .Where(d => d.EndsWith(year)))
        {
            Console.WriteLine(birthDate);
        }
    }
}
