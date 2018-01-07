using System;

class Mouse : Mammal
{
    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void Eat(Food food)
    {
        if (!(food is Vegetable))
        {
            throw new ArgumentException("Mouses are not eating that type of food!");
        }

        base.Eat(food);
    }

    public override string MakeSound()
    {
        return "SQUEEEAAAK!";
    }
}
