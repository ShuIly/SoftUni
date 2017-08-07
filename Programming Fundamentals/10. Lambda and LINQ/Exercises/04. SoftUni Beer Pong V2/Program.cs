using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Beer_Pong_V2
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Dictionary<string, int>> teams =
				new Dictionary<string, Dictionary<string, int>>();

			string command = Console.ReadLine();

			while (command != "stop the game")
			{
				string[] inputInfo = command.Split('|');
				string playerName = inputInfo[0];
				string teamName = inputInfo[1];
				int playerPoints = int.Parse(inputInfo[2]);

				if (!teams.ContainsKey(teamName) )
				{
					teams.Add(teamName, new Dictionary<string, int>());
				}

				if (teams[teamName].Values.Count < 3)
				{
					teams[teamName].Add(playerName, playerPoints);
				}

				command = Console.ReadLine();
			}

			int teamPlace = 1;
			foreach (KeyValuePair<string, Dictionary<string, int>> team in teams
				.Where(x => x.Value.Count == 3)
				.OrderByDescending(x => x.Value.Values.Sum()))
			{
				string teamName = team.Key;
				Console.WriteLine("{0}. {1}; Players:", teamPlace, teamName);

				foreach (KeyValuePair<string, int> player in teams[teamName]
					.OrderByDescending(x => x.Value))
				{
					string playerName = player.Key;
					int playerPoints = player.Value;
					Console.WriteLine("###{0}: {1}", playerName, playerPoints);
				}

				teamPlace++;
			}
		}
	}
}
