using System.Collections.Generic;

public static class GenericCollectionManager
{
    public static void SwapGenerics<T>(IList<T> list, int firstElementIndex, int secondElementIndex)
    {
        T temp = list[firstElementIndex];
        list[firstElementIndex] = list[secondElementIndex];
        list[secondElementIndex] = temp;
    }
}
