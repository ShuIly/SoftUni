using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.CottageScraper
{
	class Program
	{
		static void Main(string[] args)
		{
			var logs = new Dictionary<string, List<int>>();
			string input = Console.ReadLine();

			while (input != "chop chop")
			{
				string[] inputTokens = input
					.Split(new string[] { " -> " }, StringSplitOptions.RemoveEmptyEntries);
				string logType = inputTokens[0];
				int numLogs = int.Parse(inputTokens[1]);

				if (!logs.ContainsKey(logType))
				{
					logs.Add(logType, new List<int>());
				}

				logs[logType].Add(numLogs);
				input = Console.ReadLine();
			}

			string useLog = Console.ReadLine();
			int minLogLength = int.Parse(Console.ReadLine());

			int sumAllLogs = logs.Sum(x => x.Value.Sum());
			int logCount = logs.Sum(x => x.Value.Count);
			decimal pricePerMeter = Math.Round((decimal) sumAllLogs / logCount, 2);

			int usedLogsSum = logs[useLog].Where(x => x >= minLogLength).Sum();
			decimal usedLogsPrice = Math.Round(usedLogsSum * pricePerMeter, 2);

			int unusedLogsSum = sumAllLogs - usedLogsSum;
			decimal unusedLogsPrice = Math.Round(unusedLogsSum * pricePerMeter * (decimal) 0.25, 2);

			decimal sumLogsPrice = Math.Round(usedLogsPrice + unusedLogsPrice, 2);

			Console.WriteLine("Price per meter: ${0:F2}", pricePerMeter);
			Console.WriteLine("Used logs price: ${0:F2}", usedLogsPrice);
			Console.WriteLine("Unused logs price: ${0:F2}", unusedLogsPrice);
			Console.WriteLine("CottageScraper subtotal: ${0:F2}", sumLogsPrice);
		}
	}
}
