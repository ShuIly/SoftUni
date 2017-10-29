using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Ordered_Banking_System
{
	class Program
	{
		static void Main(string[] args)
		{
			var bankData = new Dictionary<string, Dictionary<string, decimal>>();
			string input = Console.ReadLine();
			while (input != "end")
			{
				string[] inputTokens = input
					.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
				string bankName = inputTokens[0];
				string username = inputTokens[1];
				decimal balance = decimal.Parse(inputTokens[2]);

				if (!bankData.ContainsKey(bankName))
				{
					bankData.Add(bankName, new Dictionary<string, decimal>());
				}

				if (!bankData[bankName].ContainsKey(username))
				{
					bankData[bankName].Add(username, balance);
				}
				else
				{
					bankData[bankName][username] += balance;
				}

				input = Console.ReadLine();
			}

			foreach (var bank in bankData
				.OrderByDescending(bank => bank.Value.Values.Sum())
				.ThenByDescending(bank => bank.Value.Values.Max()))
			{
				string bankName = bank.Key;
				foreach (var user in bankData[bankName]
					.OrderByDescending(user => user.Value))
				{
					string username = user.Key;
					decimal balance = user.Value;
					Console.WriteLine($"{username} -> {balance} ({bankName})");
				}
			}
		}
	}
}
