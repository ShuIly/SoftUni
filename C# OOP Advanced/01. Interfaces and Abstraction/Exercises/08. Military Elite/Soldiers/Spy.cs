using System;
using Soldiers.Private;

class Spy : Soldier
{
    private int codeNumber;

    public int CodeNumber
    {
        get => this.codeNumber;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(CodeNumber)} cannot be negative.");
            }

            this.codeNumber = value;
        }
    }

    public Spy(string id, string firstName, string lastName, int codeNumber) 
        : base(id, firstName, lastName)
    {
        this.CodeNumber = codeNumber;
    }

    public override string ToString()
    {
        return base.ToString() + "\n" + $"Code Number: {this.CodeNumber}";
    }
}
