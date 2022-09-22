namespace Assignment2;

public class Queries
{
    public static IEnumerable<string> wizardsByRowlingLinq()
    {
        var wizardCol = WizardCollection.Create();

        return from c in wizardCol
            where c.Creator.Contains("Rowling")
            select c.Name;
    }

    public static IEnumerable<string> wizardsByRowlingEx()
    {
        var wizardCol = WizardCollection.Create();

        return wizardCol.Where(c => c.Creator.Contains("Rowling"))
            .Select(c => c.Name);
    }

    public static int firstSithLordLinq()
    {
        var wizardCol = WizardCollection.Create();

        var year = (from c in wizardCol
            where c.Name.Contains("Darth")
            orderby c.Year
            select c.Year).First();

        return year!.Value;
    }

    public static int firstSithLordEx()
    {
        var wizardCol = WizardCollection.Create();

        var year = wizardCol.Where(c => c.Name.Contains("Darth"))
            .MinBy(c => c.Year)!.Year;

        return year!.Value;
    }

    public static IEnumerable<(string, int?)> uniqueListHarryPotterLinq()
    {
        var wizardCol = WizardCollection.Create();

        return (from c in wizardCol
            where c.Medium.Contains("Harry Potter")
            select (c.Name, c.Year)).Distinct();
    }

    public static IEnumerable<(string, int?)> uniqueListHarryPotterEx()
    {
        var wizardCol = WizardCollection.Create();

        return wizardCol.Where(c => c.Medium.Contains("Harry Potter"))
            .Select(c => (c.Name, c.Year))
            .Distinct();
    }

    public static IEnumerable<string> wizardNamesLinq()
    {
        var wizardCol = WizardCollection.Create();

        return from c in wizardCol
            orderby c.Creator descending, c.Name
            select c.Name;
    }

    public static IEnumerable<string> wizardNamesEx()
    {
        var wizardCol = WizardCollection.Create();

        return wizardCol.OrderByDescending(c => c.Creator)
            .ThenBy(c => c.Name)
            .Select(c => c.Name);
    }
}
