using System;

class Citizen : IPerson
{
    private string name;
    private int age;

    public string Name
    {
        get => this.name;
        private set
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

    public Citizen(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
