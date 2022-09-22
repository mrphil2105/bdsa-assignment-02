namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Test_reverse()
    {
        // Given
        var words = "This is";

        // When
        Action<string> r = s => Console.WriteLine(new string(s.ToCharArray().Reverse().ToArray()));

        // Then
        r(words);
    }

    [Fact]
    public void Test_product()
    {
        // Given
        var f1 = 0.3;
        var f2 = 1.4;

        // When
        Func<double, double, double> d = (f1, f2) => f1 * f2;

        // Then
        d(f1,f2).Should().Be(0.42);
    }

    [Fact]
    public void Test_equals_true()
    {
        // Given
        var s = " 0042";
        var i = 42;

        // When
        Func<string, int, bool> d = (s, i) => {
            if (int.TryParse(s, out var num))
            {
                return num == i;
            }

            return false;
        };

        // Then
        d(s,i).Should().BeTrue();
    }

    [Fact]
    public void Test_equals_false()
    {
        // Given
        var s = "fwe32";
        var i = 42;

        // When
        Func<string, int, bool> d = (s, i) => {
            if (int.TryParse(s, out var num))
            {
                return num == i;
            }

            return false;
        };

        // Then
        d(s,i).Should().BeFalse();
    }
}
