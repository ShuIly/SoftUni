using System;
using System.Linq;

namespace DungeonsAndCodeWizards
{
    public class Engine
    {
        private readonly DungeonMaster dungeon;

        public Engine()
        {
            this.dungeon = new DungeonMaster();
        }

        public void Run()
        {
            while (!dungeon.IsGameOver())
            {
                string result = "";

                string input = Console.ReadLine();
                if (String.IsNullOrEmpty(input))
                {
                    break;
                }

                string[] commandArgs = input.Split();
                string commandType = commandArgs[0];
                string[] methodArgs = commandArgs.Skip(1).ToArray();

                try
                {
                    switch (commandType)
                    {
                        case "JoinParty":
                            result = dungeon.JoinParty(methodArgs);
                            break;
                        case "AddItemToPool":
                            result = dungeon.AddItemToPool(methodArgs);
                            break;
                        case "PickUpItem":
                            result = dungeon.PickUpItem(methodArgs);
                            break;
                        case "UseItem":
                            result = dungeon.UseItem(methodArgs);
                            break;
                        case "UseItemOn":
                            result = dungeon.UseItemOn(methodArgs);
                            break;
                        case "GiveCharacterItem":
                            result = dungeon.GiveCharacterItem(methodArgs);
                            break;
                        case "Attack":
                            result = dungeon.Attack(methodArgs);
                            break;
                        case "Heal":
                            result = dungeon.Heal(methodArgs);
                            break;
                        case "EndTurn":
                            result = dungeon.EndTurn();
                            break;
                    }

                    Console.WriteLine(result);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine("Parameter Error: " + e.Message);
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine("Invalid Operation: " + e.Message);
                }
            }

            string finalResult = "Final stats:";

            string stats = dungeon.GetStats();
            if (!String.IsNullOrWhiteSpace(stats))
            {
                finalResult += Environment.NewLine + stats;
            }

            Console.WriteLine(finalResult);
        }
    }
}
