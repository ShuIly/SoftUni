using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Sticky_Strings
{
	class Program
	{
		static void Main(string[] args)
		{
			var delimiter = Console.ReadLine();
			var numberOfStrings = int.Parse(Console.ReadLine());
			var result = string.Empty;
			var currentString = string.Empty;

			currentString = Console.ReadLine();
			result += currentString;

			for (int i = 1; i < numberOfStrings; i++)
			{
				currentString = Console.ReadLine();
				result += delimiter + currentString; 
			}

			Console.WriteLine(result);
		}
	}
}
