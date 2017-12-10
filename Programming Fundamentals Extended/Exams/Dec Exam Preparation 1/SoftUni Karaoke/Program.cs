using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace SoftUni_Karaoke
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> participants = Console.ReadLine()
				.Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			List<string> songs = Console.ReadLine()
				.Split(new[] {", "}, StringSplitOptions.RemoveEmptyEntries)
				.ToList();

			var participantsDict = new Dictionary<string, List<string>>();

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
					participantsDict.Add(singer, new List<string>());
				}

				participantsDict[singer].Add(award);
			}

			foreach (var participant in participantsDict)
			{
				Console.WriteLine($"{participant.Key}: {participant.Value.Count} awards");
				foreach (var VARIABLE in participant.Value)
				{
					
				}
			}
		}
	}
}
