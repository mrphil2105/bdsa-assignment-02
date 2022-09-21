namespace Assignment2.Tests;
using Assignment2;
public class ExtensionsTests
{
    [Fact]
    public void TestGetSecure()
    {
        var testUri = new Uri("https://example.com");
        Assert.True(Extensions.GetSecure(testUri));
    }
    [Fact]
    public void TestWordCount()
    {
        var testString = "Hello There This is 1203 !<_Peter Speaking";
        Assert.Equal(6, Extensions.WordCount(testString));
    }
    
}
