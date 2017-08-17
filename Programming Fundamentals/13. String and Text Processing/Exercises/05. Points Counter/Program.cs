using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Points_Counter
{
	class Team
	{
		public string Name { get; set; }
		public int Points { get; set; }
		public Player MVP { get; set; }
		public Dictionary<string, Player> Players { get; set; }

		public Team(string name)
		{
			Name = name;
			Players = new Dictionary<string, Player>();
		}

		public void AddPlayer(string name, int points)
		{
			if (!Players.ContainsKey(name))
			{
				Players.Add(name, new Player(name, points));
				Points += points;
			}
			else
			{
				// If player exists check if his new points are more or less
				// than last time. Then add or subtract points from the team.
				int lastPoints = Players[name].Points;
				Players[name].Points = points;

				if (lastPoints > points)
				{
					Points -= lastPoints - points;
				}
				else
				{
					Points += points - lastPoints;
				}
			}

			// Check if player's points are more than MVP's points.
			// If yes, the current player becomes the new MVP.
			if (MVP == null || points > MVP.Points)
			{
				MVP = Players[name];
			}
		}
	}

	class Player
	{
		public string Name { get; set; }
		public int Points { get; set; }

		public Player(string name, int points)
		{
			Name = name;
			Points = points;
		}
	}
	class Program
	{
		public static string RemoveSymbols(string str)
		{
			StringBuilder result = new StringBuilder();
			foreach (char c in str)
			{
				if (char.IsLetter(c))
				{
					result.Append(c);
				}
			}
			return result.ToString();
		}

		static void Main(string[] args)
		{
			Dictionary<string, Team> teams = new Dictionary<string, Team>();
			string input = Console.ReadLine();
			while (input != "Result")
			{
				string[] inputTokens = input.Split('|');
				int points = int.Parse(inputTokens[2]);

				string name1 = RemoveSymbols(inputTokens[0]);
				string name2 = RemoveSymbols(inputTokens[1]);

				string teamName;
				string playerName;

				if (name1.All(c => char.IsUpper(c)))
				{
					teamName = name1;
					playerName = name2;
				}
				else
				{
					teamName = name2;
					playerName = name1;
				}

				if (!teams.ContainsKey(teamName))
				{
					teams.Add(teamName, new Team(teamName));
				}

				teams[teamName].AddPlayer(playerName, points);
				input = Console.ReadLine();
			}

			foreach (var team in teams
				.OrderByDescending(t => t.Value.Points)
				.ThenByDescending(t => t.Value.MVP.Points))
			{
				Console.WriteLine($"{team.Key} => {team.Value.Points}");
				Console.WriteLine($"Most points scored by {team.Value.MVP.Name}");
			}
		}
	}
}
