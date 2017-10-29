using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Cities_by_Continent_and_Country
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var continents = new Dictionary<string, Dictionary<string, List<string>>>();

			for (int i = 0; i < n; i++)
			{
				string[] location = Console.ReadLine().Split();
				string continentName = location[0];
				string countryName = location[1];
				string cityName = location[2];

				if (!continents.ContainsKey(continentName))
				{
					continents.Add(continentName, new Dictionary<string, List<string>>());
				}

				if (!continents[continentName].ContainsKey(countryName))
				{
					continents[continentName][countryName] = new List<string>();
				}
				continents[continentName][countryName].Add(cityName);
			}

			foreach (KeyValuePair<string, Dictionary<string, List<string>>> currContinent in continents)
			{
				string currContinentName = currContinent.Key;
				Dictionary<string, List<string>> countries = currContinent.Value;
				Console.WriteLine("{0}:", currContinentName);
				foreach (KeyValuePair<string, List<string>> currCountry in countries)
				{
					string currCountryName = currCountry.Key;
					List<string> cities = currCountry.Value;
					Console.WriteLine("  {0} -> {1}", 
						currCountryName, string.Join(", ", cities));
				}
			}
		}
	}
}
