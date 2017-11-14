using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Special_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			HashSet<string> specialWords = new HashSet<string>(Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

			string[] words = Console.ReadLine()
				.Split(new[] { ' ', '(', ')', '[', ']', '<', '>', ',', '-', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

			var specialWordsCount = new Dictionary<string, int>();
			foreach (var specialWord in specialWords)
			{
				specialWordsCount.Add(specialWord, 0);
			}

			foreach (var word in words)
			{
				if (specialWords.Contains(word))
				{
					specialWordsCount[word]++;
				}
			}

			foreach (var specialWord in specialWordsCount)
			{
				Console.WriteLine(specialWord.Key + " - " + specialWord.Value);
			}
		}
	}
}