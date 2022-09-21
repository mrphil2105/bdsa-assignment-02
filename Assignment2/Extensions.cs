namespace Assignment2;

public static class Extensions
{
    public static IEnumerable<int>[] xs;

    public static int[] ys;

    public static bool isSecure(this Uri uri) {
        if (uri.Scheme == Uri.UriSchemeHttps) return true;
        else return false;
    }

    public static int WordCount(this string str) =>
        str.Split(new[] { ' ', '.', '?', ',' }, StringSplitOptions.RemoveEmptyEntries).Length;

}
