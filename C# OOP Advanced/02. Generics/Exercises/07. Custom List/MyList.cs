using System;
using System.Collections.Generic;
using System.Linq;

public class MyList<T> : List<T> where T : IComparable
{
    public MyList()
    {
    }

    public MyList(IEnumerable<T> collection)
    {
        foreach (var element in collection)
        {
            this.Add(element);
        }
    }

    public void Swap(int firstIndex, int secondIndex)
    {
        T temp = this[firstIndex];
        this[firstIndex] = this[secondIndex];
        this[secondIndex] = temp;
    }

    public int CountGreaterThan(T element)
    {
        return this.Count(e => e.CompareTo(element) > 0);
    }

    public T Max()
    {
        T max = this.FirstOrDefault();
        foreach (var element in this)
        {
            if (element.CompareTo(max) > 0)
            {
                max = element;
            }
        }

        return max;
    }

    public T Min()
    {
        T min = this.FirstOrDefault();
        foreach (var element in this)
        {
            if (element.CompareTo(min) < 0)
            {
                min = element;
            }
        }

        return min;
    }
}
