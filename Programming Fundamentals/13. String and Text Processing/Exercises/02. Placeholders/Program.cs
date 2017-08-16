using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Placeholders
{
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			while (input != "end")
			{
				string[] inputTokens = input
					.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
				string[] placeholders = inputTokens[1]
					.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
				string text = inputTokens[0];

				int count = 0;
				foreach (var placeholder in placeholders)
				{
					text = text.Replace("{" + $"{count}" + "}", placeholder);
					count++;
				}

				Console.WriteLine(text);

				input = Console.ReadLine();
			}
		}
	}
}
