class Pokemon
{
    public string Name { get; }
    public string Type { get; }

    public Pokemon(string name, string type)
    {
        this.Name = name;
        this.Type = type;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Type}\n";
    }
}