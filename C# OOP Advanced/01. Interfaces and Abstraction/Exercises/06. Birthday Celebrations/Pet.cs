using System;

class Pet : IBirthable
{
    private string name;
    private string birthDate;

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

    public string BirthDate
    {
        get => this.birthDate;
        set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"{nameof(this.BirthDate)} cannot be null or whitespace.");
            }

            this.birthDate = value;
        }
    }

    public Pet(string name, string birthDate)
    {
        this.Name = name;
        this.BirthDate = birthDate;
    }
}
