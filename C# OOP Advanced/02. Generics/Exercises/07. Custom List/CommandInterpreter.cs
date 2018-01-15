using System;
using System.Linq;

public static class CommandInterpreter
{
    public static void PerformAction(ref MyList<IComparable> list, string[] cmdArgs)
    {
        string command = cmdArgs[0];

        switch (command)
        {
            case "Add": 
                list.Add(cmdArgs[1]);
                break;
            case "Remove": 
                list.RemoveAt(int.Parse(cmdArgs[1]));
                break;
            case "Contains":
                Console.WriteLine(list.Contains(cmdArgs[1]));
                break;
            case "Swap": 
                list.Swap(int.Parse(cmdArgs[1]), int.Parse(cmdArgs[2]));
                break;
            case "Greater":
                Console.WriteLine(list.CountGreaterThan(cmdArgs[1]));
                break;
            case "Max": 
                Console.WriteLine(list.Max());
                break;
            case "Min": 
                Console.WriteLine(list.Min());
                break;
            case "Print":
                list.ForEach(Console.WriteLine);
                break;
            case "Sort":
                list = new MyList<IComparable>(GenericCollectionSorter.GetSortedCollection(list));
                break;
        }
    }
}
