using System.Collections.Generic;

class AddCollection<T> : List<T>, IAdd<T>
{
    public int AddItem(T item)
    {
        this.Add(item);

        return this.Count - 1;
    }
}
