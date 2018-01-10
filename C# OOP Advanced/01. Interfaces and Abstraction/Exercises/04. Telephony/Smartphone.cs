using System;
using System.Linq;

class Smartphone : ICall, IBrowse
{
    public string Call(string number)
    {
        if (number.Any(d => !char.IsDigit(d)))
        {
            throw new ArgumentException("Invalid number!");
        }

        return $"Calling... {number}";
    }

    public string Browse(string website)
    {
        if (website.Any(d => char.IsDigit(d)))
        {
            throw new ArgumentException("Invalid URL!");
        }

        return $"Browsing: {website}!";
    }
}
