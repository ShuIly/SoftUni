using System;

class Book
{
    private string title;
    private string author;
    private decimal price;

    public string Title
    {
        get => this.title;
        set
        {
            if (String.IsNullOrWhiteSpace(value) || value.Length < 3)
            {
                throw new ArgumentException("Title not valid!");
            }

            this.title = value;
        }
    }

    public string Author
    {
        get => this.author;
        set
        {
            string[] authorNames = value
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            foreach (var name in authorNames)
            {
                if (String.IsNullOrWhiteSpace(name) || Char.IsDigit(name[0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
            }

            this.author = value;
        }
    }

    public virtual decimal Price
    {
        get => this.price;
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Price not valid!");
            }

            this.price = value;
        }
    }

    public Book(string author, string title, decimal price)
    {
        this.Title = title;
        this.Author = author;
        this.Price = price;
    }

    public override string ToString()
    {
        return $"Type: {this.GetType().Name}\n" +
            $"Title: {this.Title}\n" +
            $"Author: {this.Author}\n" +
            $"Price: {this.Price:f2}\n";
    }
}
