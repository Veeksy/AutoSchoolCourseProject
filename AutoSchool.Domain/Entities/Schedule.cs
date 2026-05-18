using AutoSchool.Domain.Enums;

namespace AutoSchool.Domain.Entities;

public sealed class Schedule : BaseEntity
{
    public long CourseId { get; set; }
    public LessonTypeEnum LessonType { get; set; }
    public DateTimeOffset DateStart { get; set; }
    public DateTimeOffset DateEnd { get; set; }
    public LocationEnum Location { get; set; }
}
