namespace Assignment2.Tests;

public class QueriesTests
{
    [Fact]
    public void Rowling_query()
    {
        // Given
        var wiz = Queries.wizardsByRowlingLinq();
    
        // When
    
        // Then
        wiz.Should().BeEquivalentTo(new List<string>{"Albus Dumbledore", "Severus Snape", "Harry Potter", "Draco Malfoy", "Ron Weasley", "Hermione Granger"});
    }
}
