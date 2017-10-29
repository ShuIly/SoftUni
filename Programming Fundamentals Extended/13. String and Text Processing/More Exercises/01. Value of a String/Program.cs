using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Value_of_a_String
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string letterCase = Console.ReadLine();

			int asciiSum = 0;
			string modifiedString;

			if (letterCase == "UPPERCASE")
			{
				modifiedString = new string(input.Where(c => char.IsLetter(c) && c.ToString() == c.ToString().ToUpper()).ToArray());
			}
			else
			{
				modifiedString = new string(input.Where(c => char.IsLetter(c) && c.ToString() == c.ToString().ToLower()).ToArray());
			}

			asciiSum = modifiedString.Select(c => (int)c).Sum();
			Console.WriteLine($"The total sum is: {asciiSum}");
		}
	}
}
