using Assignment2.Models;

namespace Assignment2.Tests;

public class StudentTests
{
    [Fact]
    public void TestIfStudentIsDropout()
    {
        var student = new Student
        {
            Id = 12123,
            GivenName = "Bent",
            Surname = "Peter",
            StartDate = new DateTime(2018, 08, 27),
            EndDate = new DateTime(2019, 06, 15)
        };

        Assert.Equal(Status.Dropout, student.Status);
    }

    [Fact]
    public void TestIfStudentIsActive()
    {
        var student = new Student
        {
            Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27)
        };

        Assert.Equal(Status.Active, student.Status);
    }

    [Fact]
    public void TestIfStudentIsNew()
    {
        var student = new Student
        {
            Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2023, 08, 27)
        };

        Assert.Equal(Status.New, student.Status);
    }

    [Fact]
    public void TestIfStudentIsGraduated()
    {
        var student = new Student
        {
            Id = 12123,
            GivenName = "Bent",
            Surname = "Peter",
            StartDate = new DateTime(2018, 08, 27),
            GraduationDate = new DateTime(2021, 06, 15)
        };

        Assert.Equal(Status.Graduated, student.Status);
    }

    [Fact]
    public void TestToStringMethod()
    {
        var student = new Student
        {
            Id = 12123,
            GivenName = "Bent",
            Surname = "Peter",
            StartDate = new DateTime(2018, 08, 27),
            GraduationDate = new DateTime(2021, 06, 15)
        };

        Assert.Equal("Id: 12123, GivenName: Bent, Surname: Peter, Status: Graduated, StartDate: 27/08/2018 00:00:00, EndDate: 01/01/1970 00:00:00, GraduationDate: 15/06/2021 00:00:00",
            student.ToString());
    }
}
