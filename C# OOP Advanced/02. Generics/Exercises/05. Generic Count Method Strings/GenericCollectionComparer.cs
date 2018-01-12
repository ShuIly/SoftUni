using System;
using System.Collections.Generic;
using System.Linq;

public static class GenericCollectionComparer
{
    public static int GetBiggerElementsCountFromList<T>(IEnumerable<T> list, T compareItem) 
        where T : IComparable<T>
    {
        return list.Count(e => compareItem.CompareTo(e) < 0);
    }
}
