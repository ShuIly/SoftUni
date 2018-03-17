using System;
using System.Collections.Generic;
using System.Linq;

class RaceTower
{
    private List<Driver> drivers;
    private Track track;

    public RaceTower()
    {
        this.drivers = new List<Driver>();
    }

    public void SetTrackInfo(int lapsNumber, int trackLength)
    {
    }

    public void RegisterDriver(List<string> commandArgs)
    {
        // Driver args.
        string type = commandArgs[0];
        string name = commandArgs[1];

        // Car args.
        int hp = int.Parse(commandArgs[2]);
        double fuelAmount = double.Parse(commandArgs[2]);

        // Tyre args.
        string[] tyreArgs = commandArgs.Skip(4).ToArray();
        Tyre tyre = TyreFactory.GetTyre(tyreArgs);

        Car car = new Car(hp, fuelAmount, tyre);

        Driver driver = DriverFactory.GetDriver(type, name, car);
        drivers.Add(driver);
    }

    public void DriverBoxes(List<string> commandArgs)
    {

    }

    public string CompleteLaps(List<string> commandArgs)
    {
        //TODO: Add some logic here …
    }

    public string GetLeaderboard()
    {
        Console.WriteLine();
    }

    public void ChangeWeather(List<string> commandArgs)
    {
        //TODO: Add some logic here …
    }
}