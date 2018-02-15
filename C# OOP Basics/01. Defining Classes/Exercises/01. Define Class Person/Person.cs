public class Person
{
    public string name;
    public int age;

    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }
}