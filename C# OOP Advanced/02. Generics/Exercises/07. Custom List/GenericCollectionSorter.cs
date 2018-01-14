using System;
using System.Collections.Generic;
using System.Linq;

public abstract class GenericCollectionSorter
{
    public static IEnumerable<T> GetSortedCollection<T>(IEnumerable<T> list)
        where T : IComparable
    {
        return list.OrderBy(e => e);
    }
}
