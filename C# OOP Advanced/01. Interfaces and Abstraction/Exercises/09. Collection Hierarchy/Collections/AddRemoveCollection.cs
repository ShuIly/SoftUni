using System.Collections.Generic;

class AddRemoveCollection<T> : List<T>, IAdd<T>, IRemove<T>
{
    public int AddItem(T item)
    {
        this.Insert(0, item);

        return 0;
    }

    public T RemoveItem()
    {
        T toBeRemoved = this[this.Count - 1];

        this.RemoveAt(this.Count - 1);

        return toBeRemoved;
    }
}
