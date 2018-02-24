using System;

class Tomcat : Cat, IProduceSound
{
    public Tomcat(string name, int age) 
        : base(name, age, "Male")
    {
    }

    public new string ProduceSound()
    {
        return "MEOW";
    }
}
