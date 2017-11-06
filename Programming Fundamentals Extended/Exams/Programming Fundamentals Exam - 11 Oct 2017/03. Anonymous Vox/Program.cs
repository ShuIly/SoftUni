using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Anonymous_Vox
{
	class Program
	{
		static void Main(string[] args)
		{
			string encodedRegex = @"([A-Za-z]+)(?<placeholder>.+)\1";
			string input = Console.ReadLine();
			Queue<string> placeholders = new Queue<string>
				(Console.ReadLine().Split(new[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries));

			string result = input;

			MatchCollection matches = Regex.Matches(input, encodedRegex);
			int count = Math.Min(matches.Count, placeholders.Count);

			int indexDiff = 0;
			for (int i = 0; i < count; i++)
			{
				string matchPlaceholder = matches[i].Groups["placeholder"].Value;
				int matchPlaceholderIndex = matches[i].Groups["placeholder"].Index;
				int placeholderLength = placeholders.Peek().Length;

				result = result.Substring(0, matchPlaceholderIndex - indexDiff)
						 + placeholders.Dequeue()
						 + input.Substring(matchPlaceholderIndex + matchPlaceholder.Length);

				indexDiff += matchPlaceholder.Length - placeholderLength;
			}

			Console.WriteLine(result);
		}
	}
}
