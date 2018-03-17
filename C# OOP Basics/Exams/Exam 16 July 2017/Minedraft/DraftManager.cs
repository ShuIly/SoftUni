using System;
using System.Collections.Generic;
using System.Linq;

public class DraftManager
{

    private List<Harvester> harvesters;
    private List<Provider> providers;
    private string mode;
    private double totalMinedOre;
    private double totalEnergyStored;

    public DraftManager()
    {
        this.harvesters = new List<Harvester>();
        this.providers = new List<Provider>();
        this.totalEnergyStored = 0;
        this.totalMinedOre = 0;
        this.mode = "Full";
    }

    public string RegisterHarvester(List<string> arguments)
    {
        harvesters.Add(HarvesterFactory.GetHarvester(arguments));

        string type = arguments[0];
        string id = arguments[1];
        return $"Successfully registered {type} Harvester - {id}";
    }

    public string RegisterProvider(List<string> arguments)
    {
        string type = arguments[0];
        string id = arguments[1];
        double energyOutput = double.Parse(arguments[2]);

        providers.Add(ProviderFactory.GetProvider(type, id, energyOutput));

        return $"Successfully registered {type} Provider - {id}";
    }

    public string Day()
    {
        string resultStr = "A day has passed.\nEnergy Provided: {0}\nPlumbus Ore Mined: {0}";

        double energyProduced = providers.Sum(p => p.EnergyOutput);
        this.totalEnergyStored += energyProduced;

        if (this.mode == "Energy")
        {
            return String.Format(resultStr, energyProduced, 0);
        }

        double requiredEnergy = harvesters.Sum(h => h.EnergyRequirement);
        double oreMined = harvesters.Sum(h => h.OreOutput);

        if (this.mode == "Half")
        {
            requiredEnergy *= 0.6;
            oreMined *= 0.5;
        }

        if (totalEnergyStored < requiredEnergy)
        {
            return String.Format(resultStr, energyProduced, 0);
        }

        this.totalMinedOre += oreMined;
        return String.Format(resultStr, energyProduced, oreMined);
    }

    public string Mode(List<string> arguments)
    {
        this.mode = arguments[0];
        return $"Successfully changed working mode to {this.mode} Mode";
    }

    public string Check(List<string> arguments)
    {
        string id = arguments[0];

        Harvester harvester = harvesters.FirstOrDefault(h => h.Id == id);
        if (harvester != null)
        {
            return harvester.ToString();
        }

        Provider provider = providers.FirstOrDefault(p => p.Id == id);
        if (provider != null)
        {
            return provider.ToString();
        }

        return $"No element found with id - {id}";
    }

    public string ShutDown()
    {
        return $"System Shutdown\nTotal Energy Stored: {totalEnergyStored}\nTotal Mined Plumbus Ore: {totalMinedOre}";
    }
}
