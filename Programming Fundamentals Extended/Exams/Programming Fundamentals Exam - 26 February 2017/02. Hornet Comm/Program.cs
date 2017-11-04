using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace _02.Hornet_Comm
{
	class Program
	{
		static void Main(string[] args)
		{
			var privateMessages = new Dictionary<string, Queue<string>>();
			var broadcasts = new Dictionary<string, Queue<string>>();

			string privateMessageRegex = @"^(?<code>\d+) <-> (?<message>[A-Za-z\d]+)$";
			string broadcastRegex = @"^(?<message>[^\d]+) <-> (?<frequency>[A-Za-z\d]+)$";

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "Hornet is Green")
					break;

				Match match = Regex.Match(input, privateMessageRegex);
				if (match.Success)
				{
					string code = new String(match.Groups["code"].Value
						.Reverse().ToArray());
					string message = match.Groups["message"].Value;

					if (!privateMessages.ContainsKey(code))
						privateMessages.Add(code, new Queue<string>());

					privateMessages[code].Enqueue(message);
				}
				else
				{
					match = Regex.Match(input, broadcastRegex);
					if (!match.Success)
						break;

					StringBuilder frequency = new StringBuilder();
					foreach (char c in match.Groups["frequency"].Value)
					{
						if (Char.IsUpper(c))
							frequency.Append(Char.ToLower(c));
						else if (Char.IsLower(c))
							frequency.Append(Char.ToUpper(c));
						else
							frequency.Append(c);
					}

					string resultFrequency = frequency.ToString();
					string message = match.Groups["message"].Value;

					if (!broadcasts.ContainsKey(resultFrequency))
						broadcasts.Add(resultFrequency, new Queue<string>());

					broadcasts[resultFrequency].Enqueue(message);
				}
			}

			Console.WriteLine("Broadcasts:");
			if (broadcasts.Count > 0)
			{
				foreach (string frequency in broadcasts.Keys)
				{
					while (broadcasts[frequency].Count > 0)
						Console.WriteLine($"{frequency} -> {broadcasts[frequency].Dequeue()}");
				}
			}
			else
				Console.WriteLine("None");

			Console.WriteLine("Messages:");
			if (privateMessages.Count > 0)
			{
				foreach (string code in privateMessages.Keys)
				{
					while (privateMessages[code].Count > 0)
						Console.WriteLine($"{code} -> {privateMessages[code].Dequeue()}");
				}
			}
			else
				Console.WriteLine("None");
		}
	}
}