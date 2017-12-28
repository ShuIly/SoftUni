using System;
using System.Collections.Generic;

class Person
{
    private string name;
    private double money;
    private List<Product> products;

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

    public double Money
    {
        get => this.money;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Money cannot be negative");
            }

            this.money = value;
        }
    }

    public Person(string name, double money)
    {
        this.Name = name;
        this.Money = money;
        this.products = new List<Product>();
    }

    public void BuyProduct(Product product)
    {
        this.Money -= product.Cost;
        this.products.Add(product);
    }

    public override string ToString()
    {
        string productsOutput = products.Count == 0 ? "Nothing bought" : String.Join(", ", products);
        return $"{this.Name} - {productsOutput}";
    }
}
