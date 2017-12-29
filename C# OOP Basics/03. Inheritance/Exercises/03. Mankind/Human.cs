using System;

class Human
{
    private const int MinFirstNameLength = 4;
    private const int MinLastNameLength = 3;

    private string firstName;
    private string lastName;

    public string FirstName
    {
        get => this.firstName;
        set
        {
            if (!Char.IsUpper(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {nameof(firstName)}");
            }

            if (value.Length < MinFirstNameLength)
            {
                throw new ArgumentException($"Expected length at least {MinFirstNameLength} symbols! Argument: {nameof(firstName)}");
            }

            this.firstName = value;
        }
    }

    public string LastName
    {
        get => this.lastName;
        set
        {
            if (!Char.IsUpper(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {nameof(lastName)}");
            }

            if (value.Length < MinLastNameLength)
            {
                throw new ArgumentException($"Expected length at least {MinLastNameLength} symbols! Argument: {nameof(lastName)}");
            }

            this.lastName = value;
        }
    }

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }

    public override string ToString()
    {
        return $"First Name: {this.FirstName}\n" +
               $"Last Name: {this.LastName}";
    }
}
