abstract class Animal
{
    protected string name;
    protected double weight;
    protected int foodEaten;

    protected Animal(string name, double weight)
    {
        this.name = name;
        this.weight = weight;
    }

    public abstract string MakeSound();

    public virtual void Eat(Food food)
    {
        this.foodEaten = food.Quantity;
    }
}
