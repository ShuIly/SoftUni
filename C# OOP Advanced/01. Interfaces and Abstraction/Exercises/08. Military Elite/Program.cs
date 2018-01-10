using System;
using System.Collections.Generic;
using Soldiers.Private;
using _08.Military_Elite.Soldiers.Missions;
using _08.Military_Elite.Soldiers.Repairs;

class Program
{
    static void Main()
    {
        Dictionary<string, Soldier> soldiers = new Dictionary<string, Soldier>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            string[] inputArgs = input
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            string soldierType = inputArgs[0];
            string Id = inputArgs[1];

            switch (soldierType)
            {
                case "Private":
                    soldiers.Add(Id, new Private(inputArgs[1], inputArgs[2], inputArgs[3], double.Parse(inputArgs[4])));
                    break;
                case "LeutenantGeneral":
                    var general = new LeutenantGeneral(inputArgs[1], inputArgs[2], inputArgs[3], double.Parse(inputArgs[4]));
                    for (int i = 5; i < inputArgs.Length; i++)
                    {
                        general.AddPrivate((Private)soldiers[inputArgs[i]]);
                    }
                    soldiers.Add(Id, general);
                    break;
                case "Engineer":
                    Engineer engineer = null;
                    try
                    {
                        engineer = new Engineer(inputArgs[1], inputArgs[2], inputArgs[3], double.Parse(inputArgs[4]), inputArgs[5]);

                        for (int i = 6; i < inputArgs.Length; i += 2)
                        {
                            engineer.AddRepair(new Repair(inputArgs[i], int.Parse(inputArgs[i + 1])));
                        }
                        soldiers.Add(Id, engineer);
                    }
                    catch (Exception)
                    {
                    }
                    break;
                case "Commando":
                    var commando = new Commando(inputArgs[1], inputArgs[2], inputArgs[3], double.Parse(inputArgs[4]), inputArgs[5]);
                    for (int i = 6; i < inputArgs.Length; i += 2)
                    {
                        try
                        {
                            commando.CompleteMission(new Mission(inputArgs[i], inputArgs[i + 1]));
                        }
                        catch (Exception)
                        {
                        }
                    }
                    soldiers.Add(Id, commando);
                    break;
                case "Spy":
                    soldiers.Add(Id, new Spy(inputArgs[1], inputArgs[2], inputArgs[3], int.Parse(inputArgs[4])));
                    break;
            }
        }

        foreach (var soldier in soldiers.Values)
        {
            Console.WriteLine(soldier);
        }
    }
}
