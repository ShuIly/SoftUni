using System;

abstract class Animal : IProduceSound
{
    private string name;
    private int age;
    private string gender;

    public string Name
    {
        get => this.name;
        private set
        {
            if (String.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Invalid input!");
            }

            this.name = value;
        }
    }

    public int Age
    {
        get => this.age;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Invalid input!");
            }

            this.age = value;
        }
    }

    public virtual string Gender
    {
        get => this.gender;
        protected set
        {
            if (value != "Male" && value != "Female")
            {
                throw new ArgumentException("Invalid input!");
            }

            this.gender = value;
        }
    }

    protected Animal(string name, int age, string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }

    public abstract string ProduceSound();

    public override string ToString()
    {
        return this.GetType().Name + "\n" +
               $"{this.Name} {this.Age} {this.Gender}";
    }
}
