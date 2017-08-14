using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Products
{
	class Product
	{

		private static Dictionary<string, Product> products =
			GetStockProducts();

		private static Dictionary<string, Product> activeProducts =
			new Dictionary<string, Product>();

		private static HashSet<string> productTypes =
			new HashSet<string>()
			{
				"Electronics",
				"Food",
				"Domestics"
			};

		public string Name { get; set; }
		public string Type { get; set; }
		public decimal Price { get; set; }
		public int Quantity { get; set; }

		public Product(string name, string type, decimal price, int quantity)
		{
			Name = name;
			Type = type;
			Price = price;
			Quantity = quantity;
		}

		public static void AddProduct(string name, string type, decimal price, int quantity)
		{
			Product product = new Product(name, type, price, quantity);

			// If product already exists just update its price and quantity
			if (products.ContainsKey(name) && products[name].Type == type)
			{
				products[name] = product;
			}
			else
			{
				productTypes.Add(type);
				activeProducts[name] = product;
			}
		}

		public decimal GetSumPrice()
		{
			return Quantity * Price;
		}

		public void PrintProduct()
		{
			Console.WriteLine($"{Type}, Product: {Name}");
			Console.WriteLine($"Price: ${Price}, Amount Left: {Quantity}");
		}

		private static Dictionary<string, Product> GetStockProducts()
		{
			Dictionary<string, Product> stockedProducts =
				new Dictionary<string, Product>();

			// In case database text file doesn't exist
			if (!File.Exists("products-database.txt"))
			{
				File.Create("products-database.txt");
				return stockedProducts;
			}

			using (StreamReader reader = new StreamReader("products-database.txt"))
			{
				while (!reader.EndOfStream)
				{
					string[] tokens = reader.ReadLine().Split();
					if (tokens.Length != 4)
					{
						continue;
					}
					string name = tokens[0];
					string type = tokens[1];
					decimal price = decimal.Parse(tokens[2]);
					int quantity = int.Parse(tokens[3]);

					Product product = new Product(name, type, price, quantity);
					stockedProducts.Add(name, product);
				}
			}

			return stockedProducts;
		}

		public static void PrintStockedProducts()
		{
			Dictionary<string, Product> stockedProducts = GetStockProducts();

			if (stockedProducts.Count > 0)
			{
				foreach (var product in stockedProducts
					.OrderBy(p => p.Value.Type))
				{
					product.Value.PrintProduct();
				}
			}
			else
			{
				Console.WriteLine("No products stocked");
			}
		}

		public static void PrintSales()
		{
			Dictionary<string, decimal> typeSumDict =
				new Dictionary<string, decimal>();

			foreach (var type in productTypes)
			{
				decimal productTypeSum = 0;

				foreach (var product in activeProducts
					.Where(p => p.Value.Type == type))
				{
					productTypeSum += product.Value.GetSumPrice();
				}

				foreach (var product in products
					.Where(p => p.Value.Type == type))
				{
					productTypeSum += product.Value.GetSumPrice();
				}

				typeSumDict.Add(type, productTypeSum);
			}

			foreach (var typeSum in typeSumDict
				.OrderByDescending(s => s.Value))
			{
				string type = typeSum.Key;
				decimal sum = typeSum.Value;

				if (sum == 0)
				{
					Console.WriteLine("No products stocked");
				}
				else
				{
					Console.WriteLine($"{type}: ${sum:F2}");
				}
			}
		}

		public static void UpdateDatabase()
		{
			using (StreamWriter writer = new StreamWriter("products-database.txt"))
			{
				foreach (var product in products)
				{
					string name = product.Value.Name;
					string type = product.Value.Type;
					decimal price = product.Value.Price;
					int quantity = product.Value.Quantity;

					writer.WriteLine($"{name} {type} {price} {quantity}");
				}

				foreach (var product in activeProducts)
				{
					string name = product.Value.Name;
					string type = product.Value.Type;
					decimal price = product.Value.Price;
					int quantity = product.Value.Quantity;

					writer.WriteLine($"{name} {type} {price} {quantity}");
				}
			}
		}
	}

	// Honestly the only problem I have with this is that there can
	// be two objects with the same name even though their types are different.
	// For example Banana with type Food and Banana with type Electronics (stupid, right?)
	// Using a dictionary with a HashSet<Product> would solve that problem but
	// it just feels so wrong. So I have omitted that.
	class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			while (input != "exit")
			{
				switch (input)
				{
					case "analyze":
						Product.PrintStockedProducts();
						break;
					case "sales":
						Product.PrintSales();
						break;
					case "stock":
						Product.UpdateDatabase();
						break;
					default:
						string[] inputTokens = input.Split();
						string name = inputTokens[0];
						string type = inputTokens[1];
						decimal price = decimal.Parse(inputTokens[2]);
						int quantity = int.Parse(inputTokens[3]);
						Product.AddProduct(name, type, price, quantity);
						break;
				}

				input = Console.ReadLine();
			}
		}
	}
}
