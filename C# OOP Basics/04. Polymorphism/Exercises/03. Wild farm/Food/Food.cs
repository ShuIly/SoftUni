using System;

abstract class Food
{
    private int quantity;

    public int Quantity
    {
        get => this.quantity;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Food quantity cannot be negative.");
            }

            this.quantity = value;
        }
    }

    protected Food(int quantity)
    {
        this.Quantity = quantity;
    }
}
