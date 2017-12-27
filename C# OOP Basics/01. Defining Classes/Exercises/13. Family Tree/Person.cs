using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public string BirthDate { get; set; }
    public List<Person> Parents { get; }
    public List<Person> Children { get; }

    public Person(string name, string birthDate)
    {
        Parents = new List<Person>();
        Children = new List<Person>();
        this.Name = name;
        this.BirthDate = birthDate;
    }

    public override string ToString()
    {
        return this.Name + " " + this.BirthDate + "\n";
    }
}
