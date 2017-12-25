using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var trainers = new Dictionary<string, Trainer>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Tournament")
            {
                break;
            }

            string[] inputArgs = input
                .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            string trainerName = inputArgs[0];
            string pokemonName = inputArgs[1];
            string pokemonElement = inputArgs[2];
            int pokemonHealth = int.Parse(inputArgs[3]);

            if (!trainers.ContainsKey(trainerName))
            {
                trainers.Add(trainerName, new Trainer(trainerName));
            }

            Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);
            trainers[trainerName].CatchPokemon(pokemon);
        }

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            foreach (var trainer in trainers.Values)
            {
                if (trainer.Pokemons.Any(p => p.Element == input))
                {
                    trainer.AddBadge();
                }
                else
                {
                    foreach (var pokemon in trainer.Pokemons)
                    {
                        pokemon.TakeDamage();
                    }

                    trainer.DumpDeadPokemons();
                }
            }
        }

        foreach (var trainer in trainers.Values
            .OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }
}
