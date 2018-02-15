using System;
using System.Reflection;

public class Program
{
    static void Main(string[] args)
    {
        Person pesho = new Person("Pesho", 12);
        Person gosho = new Person("Gosho", 18);
        Person stamat = new Person("Stamat", 43);

        Type personType = typeof(Person);
        PropertyInfo[] fields = personType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        Console.WriteLine(fields.Length);
    }
}