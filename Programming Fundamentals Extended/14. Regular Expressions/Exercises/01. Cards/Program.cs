using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01.Cards
{
	class Program
	{
		static void Main(string[] args)
		{
			string regex = "(?<![0-9])(10|[2-9JQKA])[SHDC]";
			string input = Console.ReadLine();
			string[] cards = Regex.Matches(input, regex)
				.Cast<Match>()
				.Select(m => m.Value)
				.ToArray();
			Console.WriteLine(string.Join(", ", cards));
		}
	}
}
