namespace Assignment2.Tests;
using Assignment2.Models;

public class DelegatesTests
{
    [Fact]
    public void TestReverse()
    {
        var word = "Hello World";
        Delegates.Reverse why = s =>
        {
            foreach (char c in new string(s.ToCharArray().Reverse().ToArray()))
            {
                Console.WriteLine(c);
            }
        };

        why(word);

    }

    [Fact]
    public void TestProduct()
    {
        decimal dec1 = 0.5M;
        decimal dec2 = 2.5M;
        Delegates.Product why = (s, r) =>
        {
            return s * r;
        };

        why(dec1, dec2).Should().Be(1.25M);

    }

    [Fact]
    public void TestIsEqual()
    {
        var word = "0022";
        Delegates.IsEqual why = (i, s) =>
        {
            if (int.Parse(s) == i)
            {
                return true;
            }
            else
            {
                return false;
            }

        };

        Assert.Equal(true, why(22, "0022"));

    }
}
