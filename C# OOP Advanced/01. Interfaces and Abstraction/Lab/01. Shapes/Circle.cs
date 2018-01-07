using System;
using System.Text;

class Circle : IDrawable
{
    private int radius;

    public int Radius
    {
        get => this.radius;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.Radius)} cannot be negative.");
            }

            this.radius = value;
        }
    }

    public Circle(int radius)
    {
        this.Radius = radius;
    }

    public string Draw()
    {
        StringBuilder sb = new StringBuilder();

        double r_in = this.Radius - 0.4;
        double r_out = this.Radius + 0.4;

        for (double y = this.Radius; y >= -this.Radius; y--)
        {
            for (double x = -this.Radius; x < r_out; x += 0.5)
            {
                double value = x * x + y * y;
                if (value >= r_in * r_in && value <= r_out * r_out)
                {
                    sb.Append("*");
                }
                else
                {
                    sb.Append(" ");
                }
            }

            sb.Append(Environment.NewLine);
        }

        return sb.ToString();
    }
}
