using System;
using System.Collections.Generic;
using System.Linq;

class Person
{
    public string Name { get; }
    public Company Company{ get; set; }
    public Car Car { get; set; }
    public List<Pokemon> Pokemons { get; }
    public List<Parent> Parents { get; }
    public List<Child> Children { get; }

    public Person(string name)
    {
        this.Name = name;
        this.Children = new List<Child>();
        this.Parents = new List<Parent>();
        this.Pokemons = new List<Pokemon>();
    }

    public override string ToString()
    {
        return $"{this.Name}\n" +
               "Company:\n" + this.Company +
               "Car:\n" + this.Car +
               "Pokemon:\n" + String.Join(String.Empty, Pokemons) + 
               "Parents:\n" + String.Join(String.Empty, Parents) +
               "Children:\n" + String.Join(String.Empty, Children);
    }
}
