namespace Assignment2;
//using Assignment2;

public class Queries
{
    public static IEnumerable<string> wizardsByRowlingLinq() {
        WizardCollection wizardCol = WizardCollection.Create();
        
        //var wizards = wizardCol.GetEnumerator();
        var wizNames = from c in wizardCol
                where c.Creator.Contains("Rowling")
                select new { Name = c.Name };
                
        foreach(var w in wizNames) yield return w.Name;
    }
}
