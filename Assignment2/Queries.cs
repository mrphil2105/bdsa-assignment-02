namespace Assignment2;
//using Assignment2;

public class Queries
{
    public static IEnumerable<string> wizardsByRowlingLinq()
    {
        WizardCollection wizardCol = WizardCollection.Create();

        var wizNames = from c in wizardCol
                       where c.Creator.Contains("Rowling")
                       select new { Name = c.Name };

        foreach (var w in wizNames) yield return w.Name;
    }

    public static IEnumerable<string> wizardsByRowlingEx()
    {
        WizardCollection wizardCol = WizardCollection.Create();

        var wizNames = wizardCol
                .Where(c => c.Creator.Contains("Rowling"))
                .Select(c => new { Name = c.Name });

        foreach (var w in wizNames) yield return w.Name;
    }

    public static int firstSithLordLinq()
    {
        WizardCollection wizardCol = WizardCollection.Create();

        var year = (from c in wizardCol
            where c.Name.Contains("Darth")
            orderby c.Year
            select new {c.Year}).First();

        return year.Year!.Value;
    }

    public static int firstSithLordEx()
    {
        WizardCollection wizardCol = WizardCollection.Create();

        var year = wizardCol
            .Where(c => c.Name.Contains("Darth"))
            .MinBy(c => c.Year)!.Year;

        return year!.Value;
    }

    public static IEnumerable<(string, int)> uniqueListHarryPotterLinq()
    {
        WizardCollection wizardCol = WizardCollection.Create();

        var wizNames = (from c in wizardCol
                       where c.Medium.Contains("Harry Potter")
                       select new { Name = c.Name, Year = c.Year }).Distinct();

        foreach (var w in wizNames) yield return (w.Name, w.Year!.Value);
    }

    public static IEnumerable<(string, int)> uniqueListHarryPotterEx()
    {
        WizardCollection wizardCol = WizardCollection.Create();

        var wizNames = wizardCol
                .Where(c => c.Medium.Contains("Harry Potter"))
                .Select(c => new { Name = c.Name, Year = c.Year })
                .Distinct();

        foreach (var w in wizNames) yield return (w.Name, w.Year!.Value);
    }

    public static IEnumerable<string> wizardNamesLinq()
    {
        WizardCollection wizardCol = WizardCollection.Create();

        var wizNames = from c in wizardCol
                       orderby c.Creator descending, c.Name
                       select new { Name = c.Name };

        foreach (var w in wizNames) yield return w.Name;
    }

    public static IEnumerable<string> wizardNamesEx()
    {
        WizardCollection wizardCol = WizardCollection.Create();

        var wizNames = wizardCol
                .OrderByDescending(c => c.Creator)
                .ThenBy(c => c.Name)
                .Select(c => new { Name = c.Name });

        foreach (var w in wizNames) yield return w.Name;
    }


}
