using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Capitalize_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			while (input != "end")
			{
				string[] inputTokens = input
					.Split(new char[] { ' ', ',', '.', '!', '?', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '+', ';', ':' },
					StringSplitOptions.RemoveEmptyEntries)
					.Select(w => w.First().ToString().ToUpper() + w.Substring(1).ToLower())
					.ToArray();

				Console.WriteLine(string.Join(", ", inputTokens));

				input = Console.ReadLine();
			}
		}
	}
}
