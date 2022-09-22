namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<T> Flatten<T>(this IEnumerable<IEnumerable<T>> items)
    {
        foreach (var enumerable in items)
        {
            foreach (var item in enumerable)
            {
                yield return item;
            }
        }
    }

    public static IEnumerable<T> Filter<T>(this IEnumerable<T> items, Predicate<T> predicate)
    {
        foreach (var item in items)
        {
            if (predicate(item))
            {
                yield return item;
            }
        }
    }

    public static bool IsSecure(this Uri uri) => uri.Scheme == Uri.UriSchemeHttps;

    public static int WordCount(this string str) =>
        str.Split(new[] { ' ', '.', '?', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;
}
