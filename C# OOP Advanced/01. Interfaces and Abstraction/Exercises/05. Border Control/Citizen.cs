using System;

class Citizen : IIdentifiable
{
    private string name;
    private int age;
    private string id;

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

    public string Id
    {
        get => this.id;
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.Id)} cannot be null or whitespace.");
            }

            this.id = value;
        }
    }

    public Citizen(string name, int age, string id)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
    }
}
