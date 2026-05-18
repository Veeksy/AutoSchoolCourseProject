namespace AutoSchool.Domain.Entities;

public sealed class AttendanceTheory : BaseEntity
{
    public long ScheduleId { get; set; }
    public long StudentId { get; set; }
    public bool WasPresent { get; set; }
    public required string Topic { get; set; }
}
