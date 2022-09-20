namespace Assignment2.Tests;
using Assignment2.Models;

public class ImmutableStudentTests
{
    [Fact]
    public void TestInbuiltEqualsMethod()
    {
        var ImmutableStudent = new ImmutableStudent{Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27),EndDate = new DateTime(2019, 06, 15)};
        var ImmutableStudent2 = new ImmutableStudent{Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27),EndDate = new DateTime(2019, 06, 15)};
    
        Assert.Equal(ImmutableStudent, ImmutableStudent2);
    }

        [Fact]
    public void TestInbuiltToStringMethod()
    {
        var ImmutableStudent = new ImmutableStudent{Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27),EndDate = new DateTime(2019, 06, 15)};
    
        Assert.Equal("ImmutableStudent { Id = 12123, GivenName = Bent, Surname = Peter, Status = Dropout, StartDate = 27-08-2018 00:00:00, EndDate = 15-06-2019 00:00:00, GraduationDate = 01-01-1970 00:00:00 }", ImmutableStudent.ToString());
    }
}
