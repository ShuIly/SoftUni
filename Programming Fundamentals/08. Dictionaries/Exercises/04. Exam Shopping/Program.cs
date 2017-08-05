using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Exam_Shopping
{
	class Program
	{
		static void Main(string[] args)
		{
			Dictionary<string, int> products = new Dictionary<string, int>();

			string command = Console.ReadLine();
			while (command != "shopping time")
			{
				string[] productInfo = command.Split();
				string productName = productInfo[1];
				int productQuantity = int.Parse(productInfo[2]);

				if (products.ContainsKey(productName))
				{
					products[productName] += productQuantity;
				}
				else
				{
					products.Add(productName, productQuantity);
				}

				command = Console.ReadLine();
			}

			command = Console.ReadLine();
			while (command != "exam time")
			{
				string[] productInfo = command.Split();
				string productName = productInfo[1];
				int productQuantity = int.Parse(productInfo[2]);

				if (products.ContainsKey(productName))
				{
					if (products[productName] > 0)
					{
						products[productName] -= productQuantity;

						if (products[productName] < 0)
						{
							products[productName] = 0;
						}
					}
					else
					{
						Console.WriteLine($"{productName} out of stock");
					}
				}
				else
				{
					Console.WriteLine($"{productName} doesn't exist");
				}

				command = Console.ReadLine();
			}

			foreach (KeyValuePair<string, int> item in products)
			{
				if (item.Value > 0)
				{
					Console.WriteLine("{0} -> {1}", item.Key, item.Value);
				}
			}
		}
	}
}
