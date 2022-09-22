namespace Assignment2.Tests;

public class DelegatesTests
{
    [Fact]
    public void Test_reverse()
    {
        // Given
        var words = "This is";
    
        // When
        Delegates.Reverse r = s => Console.WriteLine(new string(s.ToCharArray().Reverse().ToArray()));
    
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
        Delegates.Product d = (f1, f2) => f1 * f2;
        // Delegates.Product d = delegate(double f1, double f2) {
        //     return f1 * f2;
        // };
    
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
        Delegates.IsEqual d = delegate(string s, int i) {
            try {
                return int.Parse(s) == i;
            }
            catch {
                return false;
            }
        };
    
        // Then
        d(s,i).Should().Be(true);
    }

    [Fact]
    public void Test_equals_false()
    {
        // Given
        var s = "fwe32";
        var i = 42;
    
        // When
        Delegates.IsEqual d = delegate(string s, int i) {
            try {
                return int.Parse(s) == i;
            }
            catch {
                return false;
            }
        };
    
        // Then
        d(s,i).Should().Be(false);
    }
}
