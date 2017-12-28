using System;
using System.Collections.Generic;
using System.Linq;

class Team
{
    private string name;
    private Dictionary<string, Player> players;

    public string Name
    {
        get => this.name;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("A name should not be empty.");
            }

            this.name = value;
        }
    }

    public double Rating
    {
        get
        {
            if (players.Count == 0)
            {
                return 0;
            }

            return Math.Round(this.players.Values.Average(p => p.OverallSkill));
        }
    } 

    public Team(string name)
    {
        this.name = name;
        this.players = new Dictionary<string, Player>();
    }

    public void AddPlayer(Player player)
    {
        if (players.ContainsKey(player.Name))
        {
            throw new Exception("A player with that name already exists.");
        }

        players.Add(player.Name, player);
    }

    public void RemovePlayer(string playerName)
    {
        if (!players.ContainsKey(playerName))
        {
            throw new Exception($"Player {playerName} is not in {this.Name} team.");
        }

        players.Remove(playerName);
    }
}
