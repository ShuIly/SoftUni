using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.LINQuistics
{
	class Program
	{
		static void Main(string[] args)
		{
			var collectionsData = new Dictionary<string, HashSet<string>>();
			string input = Console.ReadLine();
			while (input != "exit")
			{
				string[] inputTokens = input
					.Split(new char[] { '.', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);
				if (inputTokens.Length == 1)
				{
					string collectionName = inputTokens[0];
					int n = 0;

					// If there is nothing in dictionary and we input a number, we get a runtime error.
					// That's why we check if there are any existing elements in dictionary (Count > 0)
					if (int.TryParse(inputTokens[0], out n) && collectionsData.Count > 0)
					{
						string biggestCollection = collectionsData
							.OrderByDescending(m => m.Value.Count())
							.First()
							.Key;

						foreach (string method in collectionsData[biggestCollection]
							.OrderBy(m => m.Length)
							.Take(n))
						{
							Console.WriteLine($"* {method}");
						}
					}
					else if (collectionsData.ContainsKey(collectionName))
					{
						foreach (string method in collectionsData[collectionName]
							.OrderByDescending(m => m.Length)
							.ThenByDescending(m => m.Distinct().Count()))
						{
							Console.WriteLine($"* {method}");
						}
					}
				}
				else
				{
					string collection = inputTokens[0];
					int methodsCount = inputTokens.Length;

					if (!collectionsData.ContainsKey(collection))
					{
						collectionsData.Add(collection, new HashSet<string>());
					}

					for (int i = 1; i < methodsCount; i++)
					{
						collectionsData[collection].Add(inputTokens[i]);
					}
				}

				input = Console.ReadLine();
			}

			input = Console.ReadLine();
			string[] newInputTokens = input.Split();
			string inputMethod = newInputTokens[0];
			string inputSelection = newInputTokens[1];

			foreach (var collection in collectionsData
				.Where(c => c.Value.Contains(inputMethod))
				.OrderByDescending(c => c.Value.Count())
				.ThenByDescending(c => c.Value.Min(m => m.Length)))
			{
				string collectionName = collection.Key;
				Console.WriteLine(collectionName);

				if (inputSelection == "all")
				{
					foreach (string method in collectionsData[collectionName]
						.OrderByDescending(m => m.Length))
					{
						Console.WriteLine($"* {method}");
					}
				}
			}
		}
	}
}
