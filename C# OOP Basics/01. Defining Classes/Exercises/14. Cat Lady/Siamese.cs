class Siamese : Cat
{
    public int EarSize { get; }

    public Siamese(string name, int earSize)
        : base(name)
    {
        this.EarSize = earSize;
    }

    public override string ToString()
    {
        return base.ToString() + " " + this.EarSize;
    }
}
