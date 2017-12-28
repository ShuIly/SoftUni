using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var teamDict = new Dictionary<string, Team>();
        while (true)
        {
            string input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }

            string[] inputArgs = input
                .Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries);

            string command = inputArgs[0];
            string teamName = inputArgs[1];

            try
            {
                switch (command)
                {
                    case "Team":
                        teamDict.Add(teamName, new Team(teamName));
                        break;
                    case "Add":
                        teamDict[teamName]
                            .AddPlayer(new Player(inputArgs[2], int.Parse(inputArgs[3]),
                                int.Parse(inputArgs[4]), int.Parse(inputArgs[5]),
                                int.Parse(inputArgs[6]), int.Parse(inputArgs[7])));
                        break;
                    case "Remove":
                        teamDict[teamName].RemovePlayer(inputArgs[2]);
                        break;
                    case "Rating":
                        Console.WriteLine($"{teamName} - {teamDict[teamName].Rating}");
                        break;
                }
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
