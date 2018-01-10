using System;

class Citizen : IPerson, IIdentifiable, IBirthable
{
    private string name;
    private string id;
    private int age;
    private string birthDate;

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

    public string BirthDate
    {
        get => this.birthDate;
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.BirthDate)} cannot be null or whitespace.");
            }

            this.birthDate = value;
        }
    }

    public Citizen(string name, int age, string id, string birthDate)
    {
        this.Name = name;
        this.Age = age;
        this.Id = id;
        this.BirthDate = birthDate;
    }
}
