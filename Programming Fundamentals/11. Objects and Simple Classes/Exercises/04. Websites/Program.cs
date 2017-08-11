using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Websites
{
	class Website
	{
		public string Host { get; set; }
		public string Domain { get; set; }
		public List<string> Queries { get; set; }

		public static Website CreateWebsite(string input)
		{
			string[] inputTokens = input
				.Split(new string[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
			string host = inputTokens[0];
			string domain = inputTokens[1];

			Website website = new Website()
			{
				Host = host,
				Domain = domain
			};

			if (inputTokens.Length > 2)
			{
				website.Queries = inputTokens[2].Split(',').ToList();
			}

			return website;
		}

		public static List<Website> CreateWebsitesList()
		{
			List<Website> websitesList = new List<Website>();
			string input = Console.ReadLine();

			while (input != "end")
			{
				websitesList.Add(CreateWebsite(input));
				input = Console.ReadLine();
			}

			return websitesList;
		}

		public override string ToString()
		{
			string result = string.Format($"https://www.{Host}.{Domain}");
			if (Queries != null)
			{
				result += String.Format("/query?=[{0}]", 
					string.Join("]&[", Queries));
			}

			return result;
		}
	}

	class Program
	{
		static void Main(string[] args)
		{
			var websitesList = Website.CreateWebsitesList();
			foreach (var website in websitesList)
			{
				Console.WriteLine(website);
			}
		}
	}
}
