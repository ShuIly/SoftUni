using System;
using System.Collections.Generic;
using System.Numerics;

namespace _01.Anonymous_Downsite
{
	class Program
	{
		static void Main(string[] args)
		{
			Queue<string> affectedSites = new Queue<string>();

			int n = int.Parse(Console.ReadLine());
			BigInteger securityToken = long.Parse(Console.ReadLine());

			decimal totalLosses = 0;
			for (int i = 0; i < n; i++)
			{
				string[] inputTokens = Console.ReadLine()
					.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
				string website = inputTokens[0];
				long siteVisits = long.Parse(inputTokens[1]);
				decimal sitePrice = decimal.Parse(inputTokens[2]);

				totalLosses += siteVisits * sitePrice;
				affectedSites.Enqueue(website);
			}

			securityToken = BigInteger.Pow(securityToken, affectedSites.Count);

			while (affectedSites.Count > 0)
			{
				Console.WriteLine(affectedSites.Dequeue());
			}

			Console.WriteLine($"Total Loss: {totalLosses:F20}");
			Console.WriteLine($"Security Token: {securityToken}");
		}
	}
}