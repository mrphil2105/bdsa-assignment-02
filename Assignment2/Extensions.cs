namespace Assignment2;
using System.Text.RegularExpressions;
public static class Extensions
{


    public static Boolean GetSecure(this Uri input)
    {

        if (input.ToString().Contains("https"))
        {
            return true;
        }
        else return false;
    }


    public static int WordCount(this string input)
    {

        var pattern = @"[a-zA-Z]+";
        var reg = new Regex(pattern);
        var returnInt = 0;

        foreach (Match word in reg.Matches(input))
        {
            returnInt++;
        }


        return returnInt;
    }
}

