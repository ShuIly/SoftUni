using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sales_Report
{
	class Sale
	{
		public string Town { get; set; }
		public string Product { get; set; }
		public decimal Price { get; set; }
		public decimal Quantity { get; set; }

		public static Sale ReadSaleReport()
		{
			string[] inputTokens = Console.ReadLine().Split();
			string townName = inputTokens[0];
			string productName = inputTokens[1];
			decimal productPrice = decimal.Parse(inputTokens[2]);
			decimal productQuantity = decimal.Parse(inputTokens[3]);

			Sale saleReport = new Sale()
			{
				Town = townName,
				Product = productName,
				Price = productPrice,
				Quantity = productQuantity
			};

			return saleReport;
		}

		public static List<Sale> ReadSaleReportList()
		{
			var saleReports = new List<Sale>();
			int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				saleReports.Add(ReadSaleReport());
			}

			return saleReports;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			List<Sale> saleReports = Sale.ReadSaleReportList();
			List<string> towns = saleReports.Select(s => s.Town).Distinct().OrderBy(x => x).ToList(); 
			foreach (string town in towns)
			{
				decimal sumSales = saleReports.Where(s => s.Town == town).Sum(t => t.Price * t.Quantity);
				Console.WriteLine($"{town} -> {sumSales:F2}");
			}
		}
	}
}
