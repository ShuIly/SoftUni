using System;
using System.Collections.Generic;

class Dough
{
    private string flourType;
    private string bakingTechnique;
    private int weight;

    private static HashSet<string> validFlourTypes =
        new HashSet<string>()
        {
            "white", "wholegrain"
        };

    private static HashSet<string> validBackingTechniques =
        new HashSet<string>()
        {
            "crispy", "chewy", "homemade"
        };

    public string FlourType
    {
        get => this.flourType;
        private set
        {
            if (!validFlourTypes.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.flourType = value;
        }
    }

    public string BakingTechnique
    {
        get => this.bakingTechnique;
        private set
        {
            if (!validBackingTechniques.Contains(value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }

            this.bakingTechnique = value;
        }
    }

    public int Weight
    {
        get => this.weight;
        private set
        {
            if (value < 1 || value > 200)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }

            this.weight = value;
        }
    }

    public double Calories { get; }

    public Dough(string flourType, string bakingTechnique, int weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;

        this.Calories = 2 * this.Weight;

        switch (this.FlourType.ToLower())
        {
            case "white":
                this.Calories *= 1.5;
                break;
            case "wholegrain":
                this.Calories *= 1.0;
                break;
        }

        switch (this.BakingTechnique.ToLower())
        {
            case "crispy":
                this.Calories *= 0.9;
                break;
            case "chewy":
                this.Calories *= 1.1;
                break;
            case "homemade":
                this.Calories *= 1.0;
                break;
        }
    }
}
