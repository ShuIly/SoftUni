class Cat
{
    public string Name { get; }

    public Cat(string name)
    {
        this.Name = name;
    }

    public override string ToString()
    {
        return this.GetType() + " " + this.Name;
    }
}
