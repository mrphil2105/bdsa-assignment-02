namespace Assignment2.Models;

public record ImmutableStudent
{
    public int Id { get; init; }

    public string GivenName { get; init; }

    public string Surname { get; init; }

    public Status Status => CalculateStatus();

    public DateTime StartDate { get; init; } = DateTime.UnixEpoch;

    public DateTime EndDate { get; init; } = DateTime.UnixEpoch;

    public DateTime GraduationDate { get; init; } = DateTime.UnixEpoch;

    public Status CalculateStatus()
    {
        if (DateTime.Now < StartDate) return Status.New;

        if (EndDate != DateTime.UnixEpoch) return Status.Dropout;

        if (GraduationDate != DateTime.UnixEpoch) return Status.Graduated;

        return Status.Active;
    }
}
