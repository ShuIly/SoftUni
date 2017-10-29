using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Grocery_Shop
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, decimal> products = new Dictionary<string, decimal>();
			string input = Console.ReadLine();
			string regex = @"^(?<name>[A-Z][a-z]+):(?<price>\d+\.\d{2})$";
			while (input != "bill")
			{
				Match match = Regex.Match(input, regex);
				if (match.Success)
				{
					string productName = match.Groups["name"].Value;
					decimal productPrice = decimal.Parse(match.Groups["price"].Value);
					products[productName] = productPrice;
				}
				input = Console.ReadLine();
			}

			foreach (var product in products
				.OrderByDescending(p => p.Value))
			{
				Console.WriteLine($"{product.Key} costs {product.Value}");
			}
		}
	}
}
