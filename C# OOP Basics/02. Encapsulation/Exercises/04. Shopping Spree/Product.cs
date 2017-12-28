using System;
using System.CodeDom;

class Product
{
    private string name;
    private double cost;

    public string Name
    {
        get => this.name;
        private set
        {
            if (String.IsNullOrEmpty(value.Trim()))
            {
                throw new ArgumentException("Name cannot be empty");
            }

            this.name = value;
        }
    }

    public double Cost
    {
        get => this.cost;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.cost = value;
        }
    }

    public Product(string name, double cost)
    {
        this.Name = name;
        this.Cost = cost;
    }

    public override string ToString()
    {
        return this.Name;
    }
}
