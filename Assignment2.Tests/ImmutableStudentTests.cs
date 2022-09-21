namespace Assignment2.Tests;
using Assignment2.Models;

public class ImmutableStudentTests
{
    [Fact]
    public void Test_2_identical_students_records_equal()
    {
        var ImmutableStudent = new ImmutableStudent { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        var ImmutableStudent2 = new ImmutableStudent { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        ImmutableStudent.Equals(ImmutableStudent2).Should().Be(true);
    }

    [Fact]
    public void Test_2_identical_students_class_not_equal()
    {
        var Student = new Student { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        var Student2 = new Student { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        Student.Equals(Student2).Should().Be(false);
    }

    [Fact]
    public void Test_record_tostring()
    {
        var ImmutableStudent = new ImmutableStudent { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        ImmutableStudent.ToString().Should().Be("ImmutableStudent { Id = 12123, GivenName = Bent, Surname = Peter, Status = Dropout, StartDate = 27/08/2018 00:00:00, EndDate = 15/06/2019 00:00:00, GraduationDate = 01/01/1970 00:00:00 }");
    }


}
