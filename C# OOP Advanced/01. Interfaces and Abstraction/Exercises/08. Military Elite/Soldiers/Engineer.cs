using System;
using System.Collections;
using System.Collections.Generic;
using _08.Military_Elite.Soldiers.Repairs;

public class Engineer : SpecialisedSoldier
{
    private List<Repair> repairs = new List<Repair>();

    public IEnumerable Repairs
    {
        get
        {
            return new List<Repair>(this.repairs);
        }
    }

    public Engineer(string id, string firstName, string lastName, double salary, string corps)
        : base(id, firstName, lastName, salary, corps)
    {
        this.repairs = new List<Repair>();
    }

    public void AddRepair(Repair repair)
    {
        this.repairs.Add(repair);
    }

    public override string ToString()
    {
        string printRepairs = this.repairs.Count > 0 ? "\n  " + String.Join("\n  ", this.repairs) : String.Empty;
        return base.ToString() + $"\nRepairs:" +
               $"  {printRepairs}";
    }
}
