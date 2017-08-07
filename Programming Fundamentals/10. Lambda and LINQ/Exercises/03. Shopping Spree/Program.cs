using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Shopping_Spree
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, decimal> products = new Dictionary<string, decimal>();
			decimal budget = decimal.Parse(Console.ReadLine());
			string command = Console.ReadLine();

			while (command != "end")
			{
				string[] inputInfo = command.Split();
				string productName = inputInfo[0];
				decimal productCost = decimal.Parse(inputInfo[1]);

				// Change price of already existing products only if their
				// changed price is smaller! If product doesn't exist just add it.
				if (!products.ContainsKey(productName) || productCost < products[productName])
				{
					products[productName] = productCost;
				}

				command = Console.ReadLine();
			}

			// Get sum of all products with LINQ
			decimal sumProducts = products.Values.Sum();

			if (budget >= sumProducts)
			{
				foreach (KeyValuePair<string, decimal> product in products
					.OrderByDescending(x => x.Value)
					.ThenBy(x => x.Key.Length))
				{
					Console.WriteLine("{0} costs {1:F2}",
						product.Key, product.Value);
				}
			}
			else
			{
				Console.WriteLine("Need more money... Just buy banichka");
			}
		}
	}
}
