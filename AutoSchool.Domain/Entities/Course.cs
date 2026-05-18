using AutoSchool.Domain.Enums;

namespace AutoSchool.Domain.Entities;

public sealed class Course : BaseEntity
{
    public long CategoryId { get; set; }
    public string? Name { get; set; }
    public DateTimeOffset StartDate { get; set; }
    public DateTimeOffset EndDate { get; set; }
    public CourseStatusEnum Status { get; set; }
}
