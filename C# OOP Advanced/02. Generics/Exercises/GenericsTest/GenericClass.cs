using System.Collections.Generic;
using System.Linq;

public abstract class GenericClass
{
    public static IEnumerable<T> GetOrderedCollection<T>(IEnumerable<T> collection)
    {
        return collection.OrderBy(e => e);
    }
}
