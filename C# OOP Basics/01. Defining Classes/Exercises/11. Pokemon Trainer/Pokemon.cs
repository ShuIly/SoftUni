using System;

class Pokemon
{
    private string name;
    private string element;

    public int Health { get; private set; }

    public string Element
    {
        get => this.element;

        private set
        {
            if (value == null)
            {
                throw new Exception("Element cannot be null.");
            }

            element = value;
        }
    }

    public Pokemon(string name, string element, int health)
    {
        if (health <= 0)
        {
            throw new Exception("Pokemon initial health cannot be below 1.");
        }

        this.name = name;
        this.element = element;
        this.Health = health;
    }

    public void TakeDamage()
    {
        this.Health -= 10;
    }
}
