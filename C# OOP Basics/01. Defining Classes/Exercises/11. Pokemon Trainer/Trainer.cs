using System;
using System.Collections.Generic;

class Trainer
{
    private string name;
    private int badges;
    private HashSet<Pokemon> pokemons;

    public string Name => this.name; 
    public int Badges => this.badges;

    public HashSet<Pokemon> Pokemons
    {
        get => this.pokemons;
        private set
        {
            if (value == null)
            {
                throw new Exception("Pokemons cannot be null.");
            }

            this.pokemons = value;
        }
    }

    public Trainer(string name)
    {
        this.name = name;
        this.Pokemons = new HashSet<Pokemon>();
        this.badges = 0;
    }

    public void CatchPokemon(Pokemon pokemon)
    {
        if (pokemon == null)
        {
            throw new ArgumentNullException(nameof(pokemon));
        }

        this.Pokemons.Add(pokemon);
    }

    public void AddBadge()
    {
        this.badges++;
    }

    public void DumpDeadPokemons()
    {
        this.Pokemons.RemoveWhere(p => p.Health <= 0);
    }
}
