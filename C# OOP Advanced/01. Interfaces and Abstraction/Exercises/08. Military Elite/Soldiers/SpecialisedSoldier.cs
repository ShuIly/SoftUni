using System;
using Soldiers.Private;

public class SpecialisedSoldier : Private
{
    private string corps;

    public string Corps
    {
        get => this.corps;
        set
        {
            if (!(value == "Airforces" || value == "Marines"))
            {
                throw new ArgumentException($"Invalid {nameof(Corps)}.");
            }

            this.corps = value;
        }
    }

    public SpecialisedSoldier(string id, string firstName, string lastName, double salary, string corps) 
        : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }

    public override string ToString()
    {
        return base.ToString() + $"\nCorps: {this.Corps}";
    }
}
