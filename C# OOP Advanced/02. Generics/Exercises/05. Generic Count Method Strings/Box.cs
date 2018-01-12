using System;

public class Box<T> : IComparable<Box<T>>
    where T : IComparable<T>
{
    public T Value { get; private set; }

    public Box(T value)
    {
        this.Value = value;
    }

    public int CompareTo(Box<T> other)
    {
        return this.Value.CompareTo(other.Value);
    }

    public override string ToString()
    {
        return $"{typeof(T)}: {this.Value}";
    }
}
