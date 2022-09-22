namespace Assignment2.Tests;

public class WizardTests
{
    [Fact]
    public void WizardCollection_contains_2_wizards()
    {
        var wizards = WizardCollection.Create();

        Assert.Equal(10, wizards.Count());
    }

    [Theory]
    [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
    [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
    public void Spot_check_wizards(string name, string medium, int year, string creator)
    {
        var wizards = WizardCollection.Create();

        Assert.Contains(wizards, w => w == new Wizard(name, medium, year, creator));
    }

    [Fact]
    public void QueriesOneTest()
    {
        var testOne = Queries.QueriOne();
        Assert.Equal(new string[] { "Voldemort", "Voldemort", "Harry Potter", "Ron Weasly", "Hermione Granger" }, testOne);
    }

        [Fact]
    public void QueriesTwoTest()
    {
        var testOne = Queries.QueriTwo();
        Assert.Equal(1977, testOne.First());
    }

        [Fact]
    public void QueriesThreeTest()
    {
        var testOne = Queries.QueriThree();
        foreach(var item in testOne){
            Console.WriteLine(item.ToString());
        }
    }

        [Fact]
    public void QueriesFourTest()
    {
        var testOne = Queries.QueriOne();
        Assert.Equal(new string[] { "Voldemort", "Voldemort", "Harry Potter", "Ron Weasly", "Hermione Granger" }, testOne);
    }
}

