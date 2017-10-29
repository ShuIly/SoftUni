using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.Pokemon_Evolution
{
	class  Pokemon
	{
		internal class Evolution
		{
			public string Name { get; set; }
			public int Index { get; set; }

			public Evolution(string name, int index)
			{
				Name = name;
				Index = index;
			}
		}
		public string Name { get; set; }
		public List<Evolution> Evolutions { get; set; }

		public Pokemon(string name)
		{
			Name = name;
			Evolutions = new List<Evolution>();
		}

		public void AddEvolution(string evolution, int index)
		{
			Evolutions.Add(new Evolution(evolution, index));
		}
	}

    class Program
    {
        static void Main(string[] args)
        {
	        var pokemonDict = new Dictionary<string, Pokemon>();

	        while (true)
	        {
		        string input = Console.ReadLine();
		        if (input == "wubbalubbadubdub")
		        {
			        foreach (Pokemon pokemon in pokemonDict.Values)
			        {
						string printResult = $"# {pokemon.Name}";
						foreach (var evolution in pokemon.Evolutions
							.OrderByDescending(e => e.Index))
						{
							printResult += $"\n{evolution.Name} <-> {evolution.Index}";
						}

				        Console.WriteLine(printResult);
			        }

					break;
		        }

				if (pokemonDict.ContainsKey(input))
		        {
			        string pokemonName = input;
					string printResult = $"# {pokemonName}";

					foreach (var evolution in pokemonDict[pokemonName].Evolutions)
					{
						printResult += $"\n{evolution.Name} <-> {evolution.Index}";
					}

			        Console.WriteLine(printResult);
		        }
		        else
		        {
			        string[] inputTokens = input
				        .Split(new [] { '-', ' ', '>' }, StringSplitOptions.RemoveEmptyEntries);

					// If we actually wanted to get pokemon info
					// but that pokemon didn't exist in the dictionary
					// we shouldn't add a new pokemon but just continue.
			        if (inputTokens.Length != 3)
				        continue;

			        string pokemonDictName = inputTokens[0];
			        string evolutionType = inputTokens[1];
			        int evolutionIndex = int.Parse(inputTokens[2]);

			        if (!pokemonDict.ContainsKey(pokemonDictName))
				        pokemonDict.Add(pokemonDictName, new Pokemon(pokemonDictName));

					pokemonDict[pokemonDictName].AddEvolution(evolutionType, evolutionIndex);
		        }
	        }
        }
    }
}