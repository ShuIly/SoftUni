using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUni_Karaoke
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> participants = new HashSet<string>
				(Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries));

			HashSet<string> songs = new HashSet<string>
				(Console.ReadLine().Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries));

			var participantsDict = new Dictionary<string, SortedSet<string>>();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "dawn")
				{
					break;
				}

				string[] inputArgs = input
					.Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries);

				string singer = inputArgs[0];
				string song = inputArgs[1];
				string award = inputArgs[2];

				if (!participants.Contains(singer) || !songs.Contains(song))
				{
					continue;
				}

				if (!participantsDict.ContainsKey(singer))
				{
					participantsDict.Add(singer, new SortedSet<string>());
				}

				participantsDict[singer].Add(award);
			}

			foreach (var participant in participantsDict
				.OrderByDescending(p => p.Value.Count))
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
