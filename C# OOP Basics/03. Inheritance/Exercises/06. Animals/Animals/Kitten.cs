using System;

class Kitten : Cat, IProduceSound
{
    public Kitten(string name, int age)
        : base(name, age, "Female")
    {
    }

    public new string ProduceSound()
    {
        return "Miau";
    }
}
