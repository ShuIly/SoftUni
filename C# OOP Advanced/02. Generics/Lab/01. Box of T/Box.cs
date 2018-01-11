using System.Collections.Generic;

public class Box<T> : Stack<T>
{
    public void Add(T item)
    {
        this.Push(item);
    }

    public T Remove()
    {
        return this.Pop();
    }
}
