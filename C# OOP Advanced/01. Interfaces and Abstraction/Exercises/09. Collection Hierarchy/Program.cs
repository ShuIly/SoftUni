using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        List<IAdd<string>> addCollections = new List<IAdd<string>>
        {
            new AddCollection<string>(),
            new AddRemoveCollection<string>(),
            new MyList<string>()
        };

        List<IRemove<string>> removeCollections = new List<IRemove<string>>
        {
            (IRemove<string>) addCollections[1],
            (IRemove<string>) addCollections[2],
        };

        string[] addItems = Console.ReadLine()
            .Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

        int removeCount = int.Parse(Console.ReadLine());

        string result = String.Empty;
        foreach (var addCollection in addCollections)
        {
            result += GetIndexesFromAddToCollection(addItems, addCollection) + Environment.NewLine;
        }

        foreach (var removeCollection in removeCollections)
        {
            result += GetElementsFromRemoveFromCollection(removeCount, removeCollection) + Environment.NewLine;
        }

        Console.Write(result);
    }

    static string GetIndexesFromAddToCollection(string[] items, IAdd<string> collection)
    {
        StringBuilder result = new StringBuilder();
        foreach (var item in items)
        {
            result.Append(collection.AddItem(item) + " ");
        }

        return result.ToString();
    }

    static string GetElementsFromRemoveFromCollection(int count, IRemove<string> collection)
    {
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < count; ++i)
        {
            result.Append(collection.RemoveItem() + " ");
        }

        return result.ToString();
    }
}
