using System;
using System.Collections.Generic;
using System.Linq;

namespace _08.Hands_of_cards
{
	class Program
	{
		static int CalculatePower(string card)
		{
			switch (card)
			{
				case "J":
					return 11;
				case "Q":
					return 12;
				case "K":
					return 13;
				case "A":
					return 14;
				default:
					return int.Parse(card);
			}
		}

		static int CalculateMultiplier(char card)
		{
			switch (card)
			{
				case 'C':
					return 1;
				case 'D':
					return 2;
				case 'H':
					return 3;
				case 'S':
					return 4;
				default:
					return 0;
			}
		}

		static void Main(string[] args)
		{
			var players = new Dictionary<string, HashSet<string>>();
			while (true)
			{
				string input = Console.ReadLine();
				if (input == "JOKER")
					break;

				string[] inputTokens = input
					.Split(new[] { ':', ',' }, StringSplitOptions.RemoveEmptyEntries)
					.Select(s => s.Trim())
					.ToArray();

				string playerName = inputTokens[0];
				if (!players.ContainsKey(inputTokens[0]))
					players.Add(playerName, new HashSet<string>());

				for (int i = 1; i < inputTokens.Length; i++)
					players[playerName].Add(inputTokens[i]);
			}

			string result = "";
			foreach (var player in players.Keys)
			{
				int playerPoints = 0;
				foreach (string card in players[player])
				{
					// example card: 10H
					// suite: 10
					// face: H
					string suite = card.Substring(0, card.Length - 1);
					char face = card[card.Length - 1];

					int power = CalculatePower(suite);
					int multiplier = CalculateMultiplier(face);

					playerPoints += power * multiplier;
				}

				result += $"{player}: {playerPoints}\n";
			}

			Console.WriteLine(result);
		}
	}
}