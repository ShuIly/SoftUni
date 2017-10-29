using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Group_Continents__Countries_and_Cities
{
	class Program
	{
		static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			var continents = new SortedDictionary<string, SortedDictionary<string, SortedSet<string>>>();

			for (int i = 0; i < n; i++)
			{
				string[] location = Console.ReadLine().Split();
				string continentName = location[0];
				string countryName = location[1];
				string cityName = location[2];

				if (!continents.ContainsKey(continentName))
				{
					continents.Add(continentName, new SortedDictionary<string, SortedSet<string>>());
				}

				if (!continents[continentName].ContainsKey(countryName))
				{
					continents[continentName][countryName] = new SortedSet<string>();
				}
				continents[continentName][countryName].Add(cityName);
			}

			foreach (KeyValuePair<string, SortedDictionary<string, SortedSet<string>>> currContinent in continents)
			{
				string currContinentName = currContinent.Key;
				SortedDictionary<string, SortedSet<string>> countries = currContinent.Value;
				Console.WriteLine("{0}:", currContinentName);
				foreach (KeyValuePair<string, SortedSet<string>> currCountry in countries)
				{
					string currCountryName = currCountry.Key;
					SortedSet<string> cities = currCountry.Value;
					Console.WriteLine("  {0} -> {1}",
						currCountryName, string.Join(", ", cities));
				}
			}
		}
	}
}
