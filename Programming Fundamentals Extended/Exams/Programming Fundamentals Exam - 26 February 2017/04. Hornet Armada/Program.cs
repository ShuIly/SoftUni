using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _04.Hornet_Armada
{
	class Soldier
	{
		public string Type { get; set; }
		public long Count { get; set; }

		public Soldier(string type, long count)
		{
			Type = type;
			Count = count;
		}
	}

	class Legion
	{
		public string Name { get; set; }
		public int Activity { get; set; }
		public Dictionary<string, Soldier> Soldiers { get; set; }
		
		public Legion(string name, int activity)
		{
			Name = name;
			Activity = activity;
			Soldiers = new Dictionary<string, Soldier>();
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
	        var legions = new Dictionary<string, Legion>();
	        int n = int.Parse(Console.ReadLine());

	        for (int i = 0; i < n; i++)
	        {
		        string[] inputTokens = Console.ReadLine()
					.Split(new []{ ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries);

		        int lastActivity = int.Parse(inputTokens[0]);
		        string legionName = inputTokens[1];
		        string soldierType = inputTokens[2];
		        long soldierCount = long.Parse(inputTokens[3]);

				if (!legions.ContainsKey(legionName))
					legions.Add(legionName, new Legion(legionName, lastActivity));

		        if (!legions[legionName].Soldiers.ContainsKey(soldierType))
			        legions[legionName].Soldiers.Add(soldierType, new Soldier(soldierType, soldierCount));
		        else
			        legions[legionName].Soldiers[soldierType].Count += soldierCount;

		        if (legions[legionName].Activity < lastActivity)
			        legions[legionName].Activity = lastActivity;
	        }

			string[] soldierTokens = Console.ReadLine()
				.Split(new []{ '\\' }, StringSplitOptions.RemoveEmptyEntries);
	        if (soldierTokens.Length == 2)
	        {
		        int activity = int.Parse(soldierTokens[0]);
		        string soldierType = soldierTokens[1];

		        foreach (var legion in legions.Values
					.Where(l => l.Activity < activity && l.Soldiers.ContainsKey(soldierType))
					.OrderByDescending(l => l.Soldiers[soldierType].Count))
		        {
			        long soldierTypeCount = legion.Soldiers[soldierType].Count;
			        Console.WriteLine($"{legion.Name} -> {soldierTypeCount}");
		        }
	        }
	        else
	        {
		        string soldierType = soldierTokens[0];

		        foreach (var legion in legions.Values
					.Where(l => l.Soldiers.ContainsKey(soldierType))
					.OrderByDescending(l => l.Activity))
		        {
			        Console.WriteLine($"{legion.Activity} : {legion.Name}");
		        }
	        }
        }
    }
}