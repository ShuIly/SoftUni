using System;
using System.Collections.Generic;

class Topping
{
    private static HashSet<string> validToppingTypes =
        new HashSet<string>()
        {
            "meat", "veggies", "cheese", "sauce"
        };

    private string type;
    private int weight;

    public string Type
    {
        get => this.type;
        private set
        {
            if (!validToppingTypes.Contains(value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }

            this.type = value;
        }
    }

    public int Weight
    {
        get => this.weight;
        private set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
            }

            this.weight = value;
        }
    }

    public double Calories { get; }

    public Topping(string type, int weight)
    {
        this.Type = type;
        this.Weight = weight;

        this.Calories = 2 * this.Weight;

        switch (this.Type.ToLower())
        {
            case "meat":
                this.Calories *= 1.2;
                break;
            case "veggies":
                this.Calories *= 0.8;
                break;
            case "cheese":
                this.Calories *= 1.1;
                break;
            case "sauce":
                this.Calories *= 0.9;
                break;
        }
    }
}
