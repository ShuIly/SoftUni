class Relative
{
    public string Name { get; }
    public string BirthDate { get; }

    public Relative(string name, string birthDate)
    {
        this.Name = name;
        this.BirthDate = birthDate;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.BirthDate}\n";
    }
}
