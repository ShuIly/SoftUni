class StreetExtraordinaire : Cat
{
    public int MeowDecibels { get; }

    public StreetExtraordinaire(string name, int meowDecibels)
        : base(name)
    {
        this.MeowDecibels = meowDecibels;
    }

    public override string ToString()
    {
        return base.ToString() + " " + this.MeowDecibels;
    }
}
