﻿using System;

public static class DriverFactory
{
    public static Driver GetDriver(string type, string name, Car car)
    {
        switch (type)
        {
            case "Aggressive":
                return new AggressiveDriver(name, car);
            case "Endurance":
                return new EnduranceDriver(name, car);
            default:
                throw new ArgumentException(OutputMessages.InvalidDriverType);
        }
    }
}
