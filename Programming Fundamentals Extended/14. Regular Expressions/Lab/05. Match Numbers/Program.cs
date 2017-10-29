using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _05.Match_Numbers
{
	class Program
	{
		static void Main(string[] args)
		{
			string regex = @"(^|(?<=\s))-?\d+(\.\d+)?((?=\s)|$)";
			string input = Console.ReadLine();
			double[] matchNums = Regex.Matches(input, regex)
				.Cast<Match>()
				.Select(m => double.Parse(m.Value))
				.ToArray();

			Console.WriteLine(string.Join(" ", matchNums));
		}
	}
}
