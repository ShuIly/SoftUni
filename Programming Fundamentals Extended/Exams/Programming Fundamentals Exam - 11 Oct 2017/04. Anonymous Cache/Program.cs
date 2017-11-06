using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Anonymous_Cache
{
	class Program
	{
		static void Main(string[] args)
		{
			var datasets = new Dictionary<string, Dictionary<string, long>>();
			var cache = new Dictionary<string, Dictionary<string, long>>();

			while (true)
			{
				string input = Console.ReadLine();
				if (input == "thetinggoesskrra")
					break;

				string[] inputTokens = input
					.Split(new[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries);

				if (inputTokens.Length == 1)
				{
					if (!datasets.ContainsKey(inputTokens[0]))
					{
						datasets.Add(inputTokens[0], new Dictionary<string, long>());
						if (cache.ContainsKey(inputTokens[0]))
						{
							foreach (var cacheSet in cache[inputTokens[0]])
								datasets[inputTokens[0]].Add(cacheSet.Key, cacheSet.Value);

							cache.Remove(inputTokens[0]);
						}
					}

					continue;
				}

				string datakey = inputTokens[0];
				long datasize = long.Parse(inputTokens[1]);
				string dataset = inputTokens[2];

				if (!datasets.ContainsKey(dataset))
				{
					if (!cache.ContainsKey(dataset))
						cache.Add(dataset, new Dictionary<string, long>());
					cache[dataset].Add(datakey, datasize);
				}
				else
					datasets[dataset].Add(datakey, datasize);
			}

			if (datasets.Count > 0)
			{
				var bestDataset = datasets
					.OrderByDescending(d => d.Value.Sum(s => s.Value))
					.First();

				Console.WriteLine($"Data Set: {bestDataset.Key}, Total Size: {bestDataset.Value.Sum(s => s.Value)}");
				foreach (var datakey in bestDataset.Value)
					Console.WriteLine($"$.{datakey.Key}");
			}
		}
	}
}
