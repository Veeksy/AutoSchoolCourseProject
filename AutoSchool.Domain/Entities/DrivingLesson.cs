using AutoSchool.Domain.Enums;

namespace AutoSchool.Domain.Entities;

public sealed class DrivingLesson : BaseEntity
{
    public long ScheduleId { get; set; }
    public long InstructorId { get; set; }
    public long StudentId { get; set; }
    public long CarId { get; set; }
    public DateTimeOffset DateStart { get; set; }
    public DateTimeOffset DateEnd { get; set; }
    public DrivingLessonStatusEnum Status { get; set; }
    public long Mileage { get; set; }
    public bool studentSignature { get; set; }
    public string? Notes { get; set; }
}
