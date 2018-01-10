using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Citizen> citizens = new List<Citizen>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] citizenArgs = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            citizens.Add(new Citizen(citizenArgs[0], citizenArgs[1], int.Parse(citizenArgs[2])));
        }

        foreach (var citizen in citizens)
        {
            Console.WriteLine($"{citizen.Name}" + Environment.NewLine +
                              $"{((IResident) citizen).GetName()} {((IPerson) citizen).GetName()}");
        }
    }
}
