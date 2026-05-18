using AutoSchool.Domain.Enums;

namespace AutoSchool.Domain.Entities;

public sealed class InternalExam : BaseEntity
{
    public long CourseId { get; set; }
    public ExamTypeEnum ExamType { get; set; }
    public DateTimeOffset DateTime { get; set; }
}
