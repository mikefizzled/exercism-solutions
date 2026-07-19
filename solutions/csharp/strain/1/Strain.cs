public static class Strain
{
    public static IEnumerable<T> Keep<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (var e in collection)
        {
            if (predicate(e))
            {
                yield return e;
            }
        }
    }

    public static IEnumerable<T> Discard<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
    {
        foreach (var e in collection)
        {
            if (!predicate(e))
            {
                yield return e;
            }
        }
    }
}