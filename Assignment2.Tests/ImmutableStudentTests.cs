using Assignment2.Models;

namespace Assignment2.Tests;

public class ImmutableStudentTests
{
    [Fact]
    public void Test_2_identical_students_records_equal()
    {
        var immutableStudent = new ImmutableStudent { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        var immutableStudent2 = new ImmutableStudent { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        immutableStudent.Equals(immutableStudent2).Should().BeTrue();
    }

    [Fact]
    public void Test_2_identical_students_class_not_equal()
    {
        var student = new Student { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        var student2 = new Student { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        student.Equals(student2).Should().BeFalse();
    }

    [Fact]
    public void Test_record_tostring()
    {
        var immutableStudent = new ImmutableStudent { Id = 12123, GivenName = "Bent", Surname = "Peter", StartDate = new DateTime(2018, 08, 27), EndDate = new DateTime(2019, 06, 15) };

        immutableStudent.ToString().Should().Be("ImmutableStudent { Id = 12123, GivenName = Bent, Surname = Peter, Status = Dropout, StartDate = 27/08/2018 00:00:00, EndDate = 15/06/2019 00:00:00, GraduationDate = 01/01/1970 00:00:00 }");
    }
}
