using System;

public static class ProviderFactory
{
    public static Provider GetProvider(string type, string id, double energyOutput)
    {
        switch (type)
        {
            case "Solar":
                return new SolarProvider(id, energyOutput);
            case "Pressure":
                return new PressureProvider(id, energyOutput);
            default:
                throw new ArgumentException("Provider is not registered, because of it's Type");
        }
    }
}
