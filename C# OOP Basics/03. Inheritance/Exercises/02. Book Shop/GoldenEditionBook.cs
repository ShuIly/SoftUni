using System;

class GoldenEditionBook : Book
{
    public override decimal Price
    {
        get => base.Price;
        set => base.Price = Decimal.Multiply(value, 1.3m);
    }

    public GoldenEditionBook(string title, string author, decimal price) 
        : base(title, author, price) { }
}
