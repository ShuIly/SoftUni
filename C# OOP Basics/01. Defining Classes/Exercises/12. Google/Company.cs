class Company
{
    public string Name { get; }
    public string Department { get; }
    public double Salary { get;  }

    public Company(string name, string department, double salary)
    {
        this.Name = name;
        this.Department = department;
        this.Salary = salary;
    }

    public override string ToString()
    {
        return $"{this.Name} {this.Department} {this.Salary:F2}\n";
    }
}
