namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Rowling_query_linq()
    {
        // Given
        var wiz = Queries.wizardsByRowlingLinq();

        // Then
        wiz.Should().BeEquivalentTo(new List<string> { "Albus Dumbledore", "Severus Snape", "Harry Potter", "Ron Weasley", "Ron Weasley", "Hermione Granger" });
    }

    [Fact]
    public void Rowling_query_extension_methods()
    {
        // Given
        var wiz = Queries.wizardsByRowlingEx();

        // Then
        wiz.Should().BeEquivalentTo(new List<string> { "Albus Dumbledore", "Severus Snape", "Harry Potter", "Ron Weasley", "Ron Weasley", "Hermione Granger" });
    }

    [Fact]
    public void First_sith_linq()
    {
        // Given
        var wiz = Queries.firstSithLordLinq();

        // Then
        wiz.Should().Be(1977);
    }

    [Fact]
    public void First_sith_ex()
    {
        // Given
        var wiz = Queries.firstSithLordEx();

        // Then
        wiz.Should().Be(1977);
    }

    [Fact]
    public void Distinct_Harry_Potter_linq()
    {
        // Given
        var wiz = Queries.uniqueListHarryPotterLinq();

        // Then
        wiz.Should().BeEquivalentTo(new List<(string, int)>{("Albus Dumbledore", 2001), ("Severus Snape", 2001),
                ("Harry Potter", 2001), ("Ron Weasley", 2001), ("Hermione Granger", 2001)});
    }

    [Fact]
    public void Distinct_Harry_Potter_extension_methods()
    {
        // Given
        var wiz = Queries.uniqueListHarryPotterEx();

        // Then
        wiz.Should().BeEquivalentTo(new List<(string, int)>{("Albus Dumbledore", 2001), ("Severus Snape", 2001),
                ("Harry Potter", 2001), ("Ron Weasley", 2001), ("Hermione Granger", 2001)});
    }

    [Fact]
    public void wizardNames_linq()
    {
        // Given
        var wiz = Queries.wizardNamesLinq();

        // Then
        wiz.Should().BeEquivalentTo(new List<string> { "Gandalf", "Michael Mouse", "Sauron", "Albus Dumbledore", "Harry Potter", "Hermione Granger", "Ron Weasley", "Ron Weasley", "Severus Snape", "Darth Ron", "Darth Vader","Merlin"});
    }

    [Fact]
    public void wizardNames_extension_methods()
    {
        // Given
        var wiz = Queries.wizardNamesEx();

        // Then
        wiz.Should().BeEquivalentTo(new List<string> { "Gandalf", "Michael Mouse", "Sauron", "Albus Dumbledore", "Harry Potter", "Hermione Granger", "Ron Weasley", "Ron Weasley", "Severus Snape", "Darth Ron", "Darth Vader","Merlin"});
    }
}
