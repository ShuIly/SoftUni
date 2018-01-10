public class Ferrari : ICar
{
    public const string Model = "488-Spider";

    public string Driver { get; }

    public Ferrari(string driver)
    {
        this.Driver = driver;
    }

    public string Brake()
    {
        return "Brakes!";
    }

    public string PushPedal()
    {
        return "Zadu6avam sA!";
    }

    public override string ToString()
    {
        return $"{Model}/{this.Brake()}/{this.PushPedal()}/{this.Driver}";
    }
}
