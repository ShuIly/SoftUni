using System;

public abstract class Soldier
{
    private string id;
    private string firstName;
    private string lastName;

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

    public string FirstName
    {
        get => this.firstName;
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.FirstName)} cannot be null or whitespace.");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get => this.lastName;
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.LastName)} cannot be null or whitespace.");
            }

            this.lastName = value;
        }
    }

    protected Soldier(string id, string firstName, string lastName)
    {
        this.Id = id;
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public override string ToString()
    {
        return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
    }
}
