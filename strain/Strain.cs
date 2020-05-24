using System;
using System.Collections.Generic;

public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var output = new List<T>();
        foreach (var item in collection)
        {
            if (predicate(item))
            {
                output.Add(item);
            }
        }

        return output;
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        var output = new List<T>();
        foreach (var item in collection)
        {
            if (!predicate(item))
            {
                output.Add(item);
            }
        }

        return output;
    }
}