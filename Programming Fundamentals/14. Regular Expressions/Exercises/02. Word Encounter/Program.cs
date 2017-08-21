using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Word_Encounter
{
	class Program
	{
		static void Main(string[] args)
		{
			List<string> filteredWordsList = new List<string>();
			string validSentenceRegex = "^[A-Z].*[.!?]$";
			string filterInfo = Console.ReadLine();
			string input = Console.ReadLine();

			char letter = filterInfo[0];
			int minOccurrences = (int)char.GetNumericValue(filterInfo[1]);

			while (input != "end")
			{
				if (Regex.IsMatch(input, validSentenceRegex))
				{
					string[] words = Regex.Matches(input, @"\w+")
						.Cast<Match>()
						.Select(m => m.Value)
						.ToArray();
					foreach (string word in words)
					{
						int letterCount = 0;
						foreach (char c in word)
						{
							if (c == letter)
							{
								letterCount++;
								if (letterCount == minOccurrences)
								{
									filteredWordsList.Add(word);
									break;
								}
							}

						}

					}
				}
				input = Console.ReadLine();
			}

			Console.WriteLine(string.Join(", ", filteredWordsList));
		}
	}
}
