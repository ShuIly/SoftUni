using System;
using System.Collections.Generic;
using _08.Military_Elite.Soldiers.Missions;

class Commando : SpecialisedSoldier
{
    private List<Mission> missions;

    public IEnumerable<Mission> Missions
    {
        get
        {
            return new List<Mission>(this.missions);
        }
    }

    public Commando(string id, string firstName, string lastName, double salary, string corps) 
        : base(id, firstName, lastName, salary, corps)
    {
        this.missions = new List<Mission>();
    }

    public void CompleteMission(Mission mission)
    {
        this.missions.Add(mission);
    }

    public override string ToString()
    {
        string printMissions = this.missions.Count > 0 ? "\n  " + String.Join("\n  ", this.missions) : String.Empty;
        return base.ToString() + "\nMissions:" +
               $"  {printMissions}";
    }
}
