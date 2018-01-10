using System;

class Rebel : IBuyer
{
    private string name;
    private int age;

    public string Name
    {
        get => this.name;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Name)} cannot be null or whitespace.");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get => this.age;
        private set 
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.Age)} cannot be negative.");
            }

            this.age = value;
        }
    }

    public int FoodBought { get; private set; }

    public Rebel(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public void BuyFood()
    {
        this.FoodBought += 5;
    }
}
