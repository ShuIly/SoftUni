public class EnduranceDriver : Driver
{
    private const double EnduranceFuelConsumption = 1.5;
    public EnduranceDriver(string name, Car car) 
        : base(name, car, EnduranceFuelConsumption)
    {
    }
}
