namespace Assignment2.Tests;
using Assignment2.Models;

public class DelegatesTests
{
    [Fact]
    public void Test1()
    {
        var word = "Hello World";
       Delegates.Reverse why = s => {
        foreach(char c in new string(s.ToCharArray().Reverse().ToArray())){
            Console.WriteLine(c);
        }
       };

       why(word);

    }
}
