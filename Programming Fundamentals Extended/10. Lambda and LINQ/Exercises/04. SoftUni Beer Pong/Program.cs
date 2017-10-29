using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SoftUni_Beer_Pong
{
	class Program
	{
		static void Main(string[] args)
		{
			var teams = new Dictionary<string, Dictionary<string, int>>();
			var teamSize = new Dictionary<string, int>();
			var teamPoints = new Dictionary<string, long>();

			string command = Console.ReadLine();

			while (command != "stop the game")
			{
				string[] inputInfo = command.Split('|');
				string playerName = inputInfo[0];
				int playerPoints = int.Parse(inputInfo[2]);
				string teamName = inputInfo[1];

				if (!teams.ContainsKey(teamName))
				{
					teams.Add(teamName, new Dictionary<string, int>());
					teamSize.Add(teamName, 0);
					teamPoints.Add(teamName, 0);
				}

				// Keep adding team members only if team size is less than 3
				if (teamSize[teamName] < 3)
				{
					teams[teamName].Add(playerName, playerPoints);
					teamSize[teamName]++;
					teamPoints[teamName] += playerPoints;
				}

				command = Console.ReadLine();
			}

			// Remove teams with less than 3 players
			Dictionary<string, int> tempTeamSize = new Dictionary<string, int>(teamSize);
			foreach (KeyValuePair<string, int> team in tempTeamSize)
			{
				if (team.Value < 3)
				{
					string teamName = team.Key;
					teams.Remove(teamName);
					teamSize.Remove(teamName);
					teamPoints.Remove(teamName);
				}
			}

			int currTeamPlace = 1;

			// Order teams by sum of points
			foreach (KeyValuePair<string, long> team in teamPoints
				.OrderByDescending(x => x.Value))
			{
				string currTeamName = team.Key;
				Console.WriteLine($"{currTeamPlace}. {currTeamName}; Players:");

				// Order team players by points
				foreach (KeyValuePair<string, int> player in teams[currTeamName]
					.OrderByDescending(x => x.Value))
				{
					string playerName = player.Key;
					int playerPoints = player.Value;
					Console.WriteLine($"###{playerName}: {playerPoints}");
				}

				currTeamPlace++;
			}
		}
	}
}
