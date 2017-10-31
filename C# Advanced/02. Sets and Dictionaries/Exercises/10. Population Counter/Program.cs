using System;
using System.Collections.Generic;
using System.Linq;

namespace _10.Population_Counter
{
	class City
	{
		public string Name { get; set; }
		public long Population { get; set; }

		public City(string name, int population)
		{
			Name = name;
			Population = population;
		}
	}

	class Country
	{
		public string Name { get; set; }
		public HashSet<City> Cities { get; set; }
		public long Population { get; set; }

		public void SetPopulation()
		{
			Population = Cities.Sum(c => c.Population);
		}

		public Country(string name)
		{
			Name = name;
			Cities = new HashSet<City>();
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
	        var countries = new Dictionary<string, Country>();

	        while (true)
	        {
		        string input = Console.ReadLine();
				if (input == "report")
					break;

		        string[] inputTokens = input
			        .Split(new[] {'|'}, StringSplitOptions.RemoveEmptyEntries);

		        string country = inputTokens[1];
		        string city = inputTokens[0];
		        int population = int.Parse(inputTokens[2]);

				if (!countries.ContainsKey(country))
					countries.Add(country, new Country(country));

				countries[country].Cities.Add(new City(city, population));
	        }

	        foreach (string country in countries.Keys)
				countries[country].SetPopulation();

	        string result = "";
	        foreach (Country country in countries.Values
				.OrderByDescending(c => c.Population))
	        {
		        result += $"{country.Name} (total population: {country.Population})\n";
		        foreach (City city in country.Cities
					.OrderByDescending(c => c.Population))
		        {
			        result += $"=>{city.Name}: {city.Population}\n";
		        }
	        }

	        Console.WriteLine(result);
        }
    }
}