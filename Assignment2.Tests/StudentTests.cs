namespace Assignment2.Tests;
using Assignment2.Models;

public class StudentTests
{
    [Fact]
    public void TestIfStudentIsDropout()
    {
        var Student = new Student{Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27),EndDate = new DateTime(2019, 06, 15)};

    
        Assert.Equal(Status.Dropout, Student.Status);
    }

    [Fact]
    public void TestIfStudentIsActive()
    {
        var Student = new Student{Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27)};

    
        Assert.Equal(Status.Active, Student.Status);
    }

    [Fact]
    public void TestIfStudentIsNew()
    {
        var Student = new Student{Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2023, 08, 27)};

    
        Assert.Equal(Status.New, Student.Status);
    }

    [Fact]
    public void TestIfStudentIsGraduated()
    {
        var Student = new Student{Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27),GraduationDate = new DateTime(2021, 06, 15)};

    
        Assert.Equal(Status.Graduated, Student.Status);
    }


        [Fact]
    public void TestToStringMethod()
    {
        var Student = new Student{Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27),GraduationDate = new DateTime(2021, 06, 15)};

    
        Assert.Equal("Id: 12123, GivenName: Bent, Surname: Peter, Status: Graduated, StartDate: 27-08-2018 00:00:00, EndDate: 01-01-1970 00:00:00, GraduationDate: 15-06-2021 00:00:00", Student.ToString());
    }
}
