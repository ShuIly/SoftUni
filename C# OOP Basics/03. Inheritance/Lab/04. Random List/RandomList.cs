using System;
using System.Collections;

class RandomList : ArrayList
{
    public string RandomString()
    {
        int index = new Random().Next(0, this.Count - 1);

        string element = this[index].ToString();

        this.Remove(this[index]);

        return element;
    }
}
