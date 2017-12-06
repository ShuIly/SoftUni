using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftUni_Karaoke
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> appliedParticipants = new HashSet<string>
				(Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries));

			HashSet<string> listedSongs = new HashSet<string>
				(Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries));

			var validParticipants = new Dictionary<string, SortedSet<string>>();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "dawn")
				{
					break;
				}

				string[] inputArgs = input
					.Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);
				string participant = inputArgs[0];
				string song = inputArgs[1];
				string award = inputArgs[2];

				if (!appliedParticipants.Contains(participant) || !listedSongs.Contains(song))
				{
					continue;
				}

				if (!validParticipants.ContainsKey(participant))
				{
					validParticipants.Add(participant, new SortedSet<string>());
				}

				validParticipants[participant].Add(award);
			}

			if (validParticipants.Count == 0)
			{
				Console.WriteLine("No awards");
				return;
			}

			foreach (var participant in validParticipants
				.OrderByDescending(p => p.Value.Count)
				.ThenBy(p => p.Key))
			{
				Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
				foreach (var award in participant.Value)
				{
					Console.WriteLine($"--{award}");
				}
			}
		}
	}
}
