using System;
using System.Collections.Generic;

namespace _13.Magic_Exchangeable_Words
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] inputArgs = Console.ReadLine()
				.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
			var charReplacements = new Dictionary<char, char>();

			string str1 = inputArgs[0];
			string str2 = inputArgs[1];

			if (inputArgs[0].Length > inputArgs[1].Length)
			{
				str1 = inputArgs[0];
				str2 = inputArgs[1];
			}
			else
			{
				str1 = inputArgs[1];
				str2 = inputArgs[0];
			}

			bool areExchangeable = true;

			for (int i = 0; i < str2.Length; i++)
			{
				if (!charReplacements.ContainsKey(str1[i]))
				{
					charReplacements.Add(str1[i], str2[i]);
				}
				else if (charReplacements[str1[i]] != str2[i])
				{
					areExchangeable = false;
					break;
				}
			}

			if (!areExchangeable)
			{
				Console.WriteLine("false");
				return;
			}

			for (int i = str2.Length; i < str1.Length; i++)
			{
				if (!charReplacements.ContainsKey(str1[i]))
				{
					areExchangeable = false;
					break;
				}
			}

			Console.WriteLine(areExchangeable ? "true" : "false");
		}
	}
}