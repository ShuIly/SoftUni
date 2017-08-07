using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Flatten_Dictionary
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, Dictionary<string, string>> products =
				new Dictionary<string, Dictionary<string, string>>();

			Dictionary<string, List<string>> flattenedProducts =
				new Dictionary<string, List<string>>();

			string input = Console.ReadLine();
			while (input != "end")
			{
				string[] inputTokens = input.Split();
				if (inputTokens[0] == "flatten")
				{
					string productGroup = inputTokens[1];

					// We can't flatten something that doesn't exist
					if (products.ContainsKey(productGroup))
					{
						if (!flattenedProducts.ContainsKey(productGroup))
						{
							flattenedProducts.Add(productGroup, new List<string>());
						}

						foreach (KeyValuePair<string, string> product in products[productGroup])
						{
							string productBrand = product.Key;
							string productName = product.Value;
							flattenedProducts[productGroup].Add(productBrand + productName);
						}

						// We empty the dictionary with the product group but we
						// don't remove it because we need its name when we print all groups
						products[productGroup] = new Dictionary<string, string>();
					}
				}
				else
				{
					string productGroup = inputTokens[0];
					string productBrand = inputTokens[1];
					string productName = inputTokens[2];

					if (!products.ContainsKey(productGroup))
					{
						products.Add(productGroup, new Dictionary<string, string>());
					}

					products[productGroup][productBrand] = productName;
				}

				input = Console.ReadLine();
			}

			foreach (KeyValuePair<string, Dictionary<string, string>> product in products
				.OrderByDescending(x => x.Key.Length))
			{
				string productGroup = product.Key;
				Console.WriteLine(productGroup);

				// Print all non-flattened products
				int productIndex = 1;
				foreach (KeyValuePair<string, string> normalProduct in products[productGroup]
					.OrderBy(x => x.Key.Length))
				{
					string productBrand = normalProduct.Key;
					string productName = normalProduct.Value;
					Console.WriteLine("{0}. {1} - {2}", productIndex, productBrand, productName);
					productIndex++;
				}

				// Print all flattened products (if they exist)
				if (flattenedProducts.ContainsKey(productGroup))
				{
					foreach (string flattenedProduct in flattenedProducts[productGroup])
					{
						Console.WriteLine("{0}. {1}", productIndex, flattenedProduct);
						productIndex++;
					}
				}
			}
		}
	}
}
