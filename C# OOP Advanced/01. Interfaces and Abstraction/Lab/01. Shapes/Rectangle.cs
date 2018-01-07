using System;
using System.Text;

class Rectangle : IDrawable
{
    private int width;
    private int height;

    public int Width
    {
        get => this.width;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.Width)} cannot be negative.");
            }

            this.width = value;
        }
    }

    public int Height
    {
        get => this.height;
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException($"{nameof(this.Height)} cannot be negative.");
            }

            this.height = value;
        }
    }

    public Rectangle(int width, int height)
    {
        this.Width = width;
        this.Height = height;
    }

    public string Draw()
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(DrawLine(this.Width, '*', '*'));

        for (int i = 1; i < this.Height - 1; i++)
        {
            sb.Append(DrawLine(this.Width, '*', ' '));
        }

        sb.Append(DrawLine(this.Width, '*', '*'));

        return sb.ToString();
    }

    public string DrawLine(int width, char end, char mid)
    {
        StringBuilder sb = new StringBuilder();

        sb.Append(end);
        for (int i = 1; i < width - 1; i++)
        {
            sb.Append(mid);
        }

        sb.Append(end + Environment.NewLine);

        return sb.ToString();
    }
}
