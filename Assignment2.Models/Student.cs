using System.Text;

namespace Assignment2.Models;

public class Student
{
    public int Id { get; init; }

    public string GivenName { get; set; }

    public string Surname { get; set; }

    public Status Status => CalculateStatus();

    public DateTime StartDate { get; set; } = DateTime.UnixEpoch;

    public DateTime EndDate { get; set; } = DateTime.UnixEpoch;

    public DateTime GraduationDate { get; set; } = DateTime.UnixEpoch;

    public Status CalculateStatus()
    {
        if (DateTime.Now < StartDate) return Status.New;

        if (EndDate != DateTime.UnixEpoch) return Status.Dropout;

        if (GraduationDate != DateTime.UnixEpoch) return Status.Graduated;

        return Status.Active;
    }

    public override string ToString()
    {
        var builder = new StringBuilder();
        builder.Append("Id: ");
        builder.Append(Id);
        builder.Append(", GivenName: ");
        builder.Append(GivenName);
        builder.Append(", Surname: ");
        builder.Append(Surname);
        builder.Append(", Status: ");
        builder.Append(Status);
        builder.Append(", StartDate: ");
        builder.Append(StartDate);
        builder.Append(", EndDate: ");
        builder.Append(EndDate);
        builder.Append(", GraduationDate: ");
        builder.Append(GraduationDate);

        return builder.ToString();
    }
}
