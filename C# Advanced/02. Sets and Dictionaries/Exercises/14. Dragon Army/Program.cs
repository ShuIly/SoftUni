using System;
using System.Collections.Generic;
using System.Linq;

namespace _14.Dragon_Army
{
	class Dragon
	{
		public string Name { get; set; }
		public int Damage { get; set; }
		public int Health { get; set; }
		public int Armor { get; set; }

		public Dragon(string name, string damage, string health, string armor)
		{
			Name = name;

			if (damage == "null")
				Damage = 45;
			else
				Damage = int.Parse(damage);

			if (health == "null")
				Health = 250;
			else
				Health = int.Parse(health);

			if (armor == "null")
				Armor = 10;
			else
				Armor = int.Parse(armor);
		}
	}
    class Program
    {
        static void Main(string[] args)
        {
			var dragons = new Dictionary<string, SortedDictionary<string, Dragon>>();
	        int n = int.Parse(Console.ReadLine());

	        for (int i = 0; i < n; i++)
	        {
		        string[] inputTokens = Console.ReadLine()
					.Split(new []{ ' ' }, StringSplitOptions.RemoveEmptyEntries);

		        string type = inputTokens[0];
		        string name = inputTokens[1];
		        string damage = inputTokens[2];
		        string health = inputTokens[3];
		        string armor = inputTokens[4];

				if (!dragons.ContainsKey(type))
					dragons.Add(type, new SortedDictionary<string, Dragon>());

		        dragons[type][name] = new Dragon(name, damage, health, armor);
	        }

	        string result = "";
	        foreach (string dragonType in dragons.Keys)
	        {
		        double averageDamage = dragons[dragonType].Average(d => d.Value.Damage);
		        double averageHealth = dragons[dragonType].Average(d => d.Value.Health);
		        double averageArmor = dragons[dragonType].Average(d => d.Value.Armor);

		        result += $"{dragonType}::({averageDamage:F2}/{averageHealth:F2}/{averageArmor:F2})\n";
		        foreach (var dragon in dragons[dragonType].Values)
		        {
			        result += $"-{dragon.Name} -> damage: {dragon.Damage}, health: {dragon.Health}, armor: {dragon.Armor}\n";
		        }
	        }

	        Console.WriteLine(result);
        }
    }
}