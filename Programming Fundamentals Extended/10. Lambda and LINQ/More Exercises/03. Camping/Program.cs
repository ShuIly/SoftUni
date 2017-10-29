using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Camping
{
	class Program
	{
		static void Main(string[] args)
		{
			var campers = new Dictionary<string, Dictionary<string, int>>();
			string input = Console.ReadLine();

			while (input != "end")
			{
				string[] inputTokens = input.Split();
				string camperName = inputTokens[0];
				string truckName = inputTokens[1];
				int nightsCamped = int.Parse(inputTokens[2]);

				if (!campers.ContainsKey(camperName))
				{
					campers.Add(camperName, new Dictionary<string, int>());
				}
				campers[camperName].Add(truckName, nightsCamped);

				input = Console.ReadLine();
			}

			foreach (KeyValuePair<string, Dictionary<string, int>> camper in campers
				.OrderByDescending(x => x.Value.Count)
				.ThenBy(x => x.Key.Length))
			{
				string camperName = camper.Key;
				int truckCount = camper.Value.Count;
				Console.WriteLine($"{camperName}: {truckCount}");

				int fullNightsCamped = 0;
				foreach (KeyValuePair<string, int> truck in campers[camperName])
				{
					fullNightsCamped += truck.Value;
					string truckName = truck.Key;
					Console.WriteLine($"***{truckName}");
				}

				Console.WriteLine($"Total stay: {fullNightsCamped} nights");
			}
		}
	}
}
