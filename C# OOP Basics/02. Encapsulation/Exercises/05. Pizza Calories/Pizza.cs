using System;
using System.Collections.Generic;
using System.Linq;

class Pizza
{
    private string name;
    private List<Topping> toppings;
    private int numberOfToppings;

    public Dough Dough { get; set; }

    public string Name
    {
        get => this.name;
        set
        {
            if (String.IsNullOrEmpty(value) || value.Length > 15)
            {
                throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");
            }

            this.name = value;
        }
    }

    public int NumberOfToppings
    {
        get => this.numberOfToppings;
        private set
        {
            if (value < 0 || value > 10)
            {
                throw new ArgumentException("Number of toppings should be in range [0..10].");
            }

            this.numberOfToppings = value;
        }
    }

    public double TotalCalories => this.Dough.Calories + this.toppings.Sum(t => t.Calories);

    public Pizza(string name, int numberOfToppings)
    {
        this.Name = name;
        this.NumberOfToppings = numberOfToppings;
        this.toppings = new List<Topping>();
    }

    public void AddTopping(Topping topping)
    {
        this.toppings.Add(topping);
    }

    public override string ToString()
    {
        return $"{this.Name} - {this.TotalCalories:F2} Calories.";
    }
}
