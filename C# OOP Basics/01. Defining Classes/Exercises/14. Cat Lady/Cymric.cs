class Cymric : Cat
{
    public double FurLength { get; }

    public Cymric(string name, double furLength)
        : base(name)
    {
        this.FurLength = furLength;
    }

    public override string ToString()
    {
        return base.ToString() + " " + $"{this.FurLength:F2}";
    }
}
