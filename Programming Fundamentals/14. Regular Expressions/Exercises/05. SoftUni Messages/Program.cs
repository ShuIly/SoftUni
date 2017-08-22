using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.SoftUni_Messages
{
	class Program
	{
		static void Main(string[] args)
		{
			string validInputPattern = @"^\d+[a-zA-Z]+[^a-zA-Z]*?\d+[^a-zA-Z]*$";
			string getWord = @"[a-zA-Z]+";

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "Decrypt!")
				{
					break;
				}

				int wordLength = int.Parse(Console.ReadLine());
				if (Regex.IsMatch(input, validInputPattern))
				{
					string word = Regex.Match(input, getWord).Value;
					if (word.Length == wordLength)
					{
						StringBuilder result = new StringBuilder();
						foreach (char c in input)
						{
							if (int.TryParse(c.ToString(), out int i) && i < word.Length)
							{
								result.Append(word[i]);
							}
						}

						Console.WriteLine($"{word} = {result}");
					}
				}
			}
		}
	}
}
