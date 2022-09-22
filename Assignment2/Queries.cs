namespace Assignment2;
using System.Linq;

public class Queries
{
    
    

public static IEnumerable<String> QueriOne(){
    var wizards = WizardCollection.Create();
    var Queries = from name in wizards where name.Creator =="J.K. Rowling" select name.Name;
    foreach (var item in Queries)
    {
        yield return item;
    }
    
}


}
