using System.Text;
namespace Assignment2.Models;

public record ImmutableStudent
{
    public int Id { get; init; }
    public String GivenName { get; init; }
    public String Surname { get; init; }
    public Status Status { get => CalculateStatus(); }
    public DateTime StartDate { get; init; } = DateTime.UnixEpoch;
    public DateTime EndDate { get; init; } = DateTime.UnixEpoch;
    public DateTime GraduationDate { get; init; } = DateTime.UnixEpoch;

    public Status CalculateStatus()
    {

        if(DateTime.Now < StartDate) return Status.New;

        else if(EndDate != DateTime.UnixEpoch) return Status.Dropout;
  
        else if(GraduationDate != DateTime.UnixEpoch) return Status.Graduated;

        else return Status.Active;
    }

}