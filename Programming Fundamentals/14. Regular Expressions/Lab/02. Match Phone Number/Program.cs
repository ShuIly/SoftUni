using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02.Match_Phone_Number
{
	class Program
	{
		static void Main(string[] args)
		{
			string regex = @"( |^)\+359([ -])2\2\d{3}\2\d{4}\b";
			string input = Console.ReadLine();

			MatchCollection phoneMatches = Regex.Matches(input, regex);

			string[] phoneArr = phoneMatches
				.Cast<Match>()
				.Select(a => a.Value.Trim())
				.ToArray();

			Console.WriteLine(string.Join(", ", phoneArr));
		}
	}
}
