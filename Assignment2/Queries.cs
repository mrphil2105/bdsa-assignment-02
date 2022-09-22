namespace Assignment2;
using System.Linq;

public class Queries
{
    
    

public static IEnumerable<String> QueriOne(){
    var wizards = WizardCollection.Create();
    var Queries = from wizard in wizards where wizard.Creator =="J.K. Rowling" select wizard.Name;
    foreach (var item in Queries)
    {
        yield return item;
    }
    
}

public static IEnumerable<int?> QueriTwo(){
    var wizards = WizardCollection.Create();
    var Queries = from wizard in wizards where wizard.Name.Contains("Darth") orderby wizard.Year select wizard.Year;
    
        yield return Queries.First();
    
    
}

public static IEnumerable<Tuple<string,int?>> QueriThree(){
    var wizards = WizardCollection.Create();
    var Queries = from wizard in wizards where wizard.Medium =="Harry Potter" select new Tuple<string, int?>(wizard.Name, wizard.Year);
    foreach (var item in Queries)
    {
        yield return item;
    }
    
}

public static IEnumerable<String> QueriFour(){
    var wizards = WizardCollection.Create();
    var Queries = from name in wizards where name.Creator =="J.K. Rowling" select name.Name;
    foreach (var item in Queries)
    {
        yield return item;
    }
    
}


}
