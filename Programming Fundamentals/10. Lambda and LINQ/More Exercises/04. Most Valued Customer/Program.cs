using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Most_Valued_Customer
{
	class Program
	{
		static void Main(string[] args)
		{
			var productData = new Dictionary<string, double>();
			var customerData = new Dictionary<string, Dictionary<string, int>>();
			string input = Console.ReadLine();

			while (input != "Shop is open")
			{
				string[] inputTokens = input.Split();
				string productName = inputTokens[0];
				double productPrice = double.Parse(inputTokens[1]);

				productData[productName] = productPrice;

				input = Console.ReadLine();
			}

			input = Console.ReadLine();

			while (input != "Print")
			{
				if (input == "Discount")
				{
					var tempProductData = new Dictionary<string, double>(productData
						.OrderByDescending(x => x.Value)
						.Take(3)
						.ToDictionary(k => k.Key, v => v.Value));

					foreach (KeyValuePair<string, double> product in tempProductData)
					{
						string currProduct = product.Key;
						double newProductCost = product.Value * 0.9;
						productData[currProduct] = newProductCost;
					}
				}
				else
				{
					string[] inputTokens = input
						.Split(new string[] { ": ", ", " }, StringSplitOptions.RemoveEmptyEntries);
					string customerName = inputTokens[0];

					if (!customerData.ContainsKey(customerName))
					{
						customerData.Add(customerName, new Dictionary<string, int>());
					}

					int boughtProductsCount = inputTokens.Length;
					for (int i = 1; i < boughtProductsCount; i++)
					{
						string currProduct = inputTokens[i];
						if (!customerData[customerName].ContainsKey(currProduct))
						{
							customerData[customerName].Add(currProduct, 1);
						}
						else
						{
							customerData[customerName][currProduct]++;
						}
					}
				}

				input = Console.ReadLine();
			}

			string biggestSpender = customerData
				.OrderByDescending(customer => customer.Value
				.Sum(product => product.Value * productData[product.Key]))
				.First()
				.Key;

			Console.WriteLine($"Biggest spender: {biggestSpender}");
			Console.WriteLine("^Products bought:");

			double totalSum = 0;
			foreach (KeyValuePair<string, int> productsBought in customerData[biggestSpender])
			{
				string productName = productsBought.Key;
				double productSumPrice = productsBought.Value * productData[productName];
				totalSum += productSumPrice;
				Console.WriteLine($"^^^{productName:F2}: {productData[productName]:F2}");
			}

			Console.WriteLine($"Total: {totalSum:F2}");
		}
	}
}
