namespace Assignment2.Tests;

public class ExtensionsTests
{
    [Fact]
    public void Test_flatten()
    {
        var xs = new IEnumerable<int>[] { new List<int> { 1, 2, 3, 4 }, new List<int> { 4, 2, 3, 4 } };

        // When
        var result = xs.Flatten();

        // Then
        result.Should().BeEquivalentTo(new List<int> { 1, 2, 3, 4, 4, 2, 3, 4 });
    }

    [Fact]
    public void Test_filter()
    {
        var ys = Enumerable.Range(0, 60).ToArray();

        // When
        var result = ys.Filter(x => x % 7 == 0 && x > 42);

        // Then
        result.Should().BeEquivalentTo(new List<int> { 49, 56 });
    }

    [Fact]
    public void LeapYear_test1()
    {
        var ys = Enumerable.Range(2002, 20).ToArray();

        // When
        var result = ys.Filter(x => (x % 4 == 0 && x % 100 != 0) || (x % 4 == 0 && x % 100 == 0 && x % 400 == 0));

        // Then
        result.Should().BeEquivalentTo(new List<int> { 2004, 2008, 2012, 2016, 2020 });
    }

    [Fact]
    public void LeapYear_test2()
    {
        var ys = Enumerable.Range(1890, 20).ToArray();

        // When
        var result = ys.Filter(x => (x % 4 == 0 && x % 100 != 0) || (x % 4 == 0 && x % 100 == 0 && x % 400 == 0));

        // Then
        result.Should().BeEquivalentTo(new List<int> { 1892, 1896, 1904, 1908 });
    }

    [Fact]
    public void Test_is_secure()
    {
        // Given
        var uri = new Uri("https://github.com/itu-bdsa/assignment-02/blob/main/README.md");

        // When
        var secure = uri.IsSecure();

        // Then
        secure.Should().BeTrue();
    }

    [Fact]
    public void Test_is_not_secure()
    {
        // Given
        var uri = new Uri("http://www.baidu.com/");

        // When
        var secure = uri.IsSecure();

        // Then
        secure.Should().BeFalse();
    }

    [Fact]
    public void Test_wordcount_5()
    {
        // Given
        var words = "Hello I study software development.";

        // When
        var count = words.WordCount();

        // Then
        count.Should().Be(5);
    }

    [Fact]
    public void Test_wordcount_3()
    {
        // Given
        var words = "my name is";

        // When
        var count = words.WordCount();

        // Then
        count.Should().Be(3);
    }
}
