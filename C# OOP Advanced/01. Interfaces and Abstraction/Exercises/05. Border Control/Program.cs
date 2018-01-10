using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<IIdentifiable> identities = new List<IIdentifiable>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] inputArgs = input
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            if (inputArgs.Length == 3)
            {
                identities.Add(new Citizen(inputArgs[0], int.Parse(inputArgs[1]), inputArgs[2]));
            }
            else
            {
                identities.Add(new Robot(inputArgs[0], inputArgs[1]));
            }
        }

        string idPart = Console.ReadLine();
        foreach (string id in identities
            .Select(p => p.Id)
            .Where(i => i.EndsWith(idPart)))
        {
            Console.WriteLine(id);
        }
    }
}
