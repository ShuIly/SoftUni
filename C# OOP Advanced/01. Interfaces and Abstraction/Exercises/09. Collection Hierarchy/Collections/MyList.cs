using System.Collections.Generic;

class MyList<T> : List<T>, IAdd<T>, IRemove<T>
{
    public int AddItem(T item)
    {
        this.Insert(0, item);

        return 0;
    }

    public T RemoveItem()
    {
        T toBeRemoved = this[0];

        this.RemoveAt(0);

        return toBeRemoved;
    }
}

