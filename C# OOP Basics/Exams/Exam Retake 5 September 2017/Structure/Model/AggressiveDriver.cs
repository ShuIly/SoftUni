public class AggressiveDriver : Driver
{
    private const double AggressiveFuelConsumption = 2.7;
    public AggressiveDriver(string name, Car car) 
        : base(name, car, AggressiveFuelConsumption)
    {
    }

    public override double Speed => base.Speed * 1.3;
}
