using System;
using Soldiers.Private;
using System.Collections.Generic;

class LeutenantGeneral : Private
{
    private List<Private> privates;

    public IEnumerable<Private> Privates
    {
        get
        {
            return new List<Private>(this.privates);
        }
    }

    public LeutenantGeneral(string id, string firstName, string lastName, double salary)
        : base(id, firstName, lastName, salary)
    {
        privates = new List<Private>();
    }

    public void AddPrivate(Private member)
    {
        privates.Add(member);
    }

    public override string ToString()
    {
        string privates = this.privates.Count > 0 ? "\n  " + String.Join("\n  ", this.privates) : String.Empty;
        return base.ToString() + "\nPrivates:" +
               $"  {privates}";
    }
}
