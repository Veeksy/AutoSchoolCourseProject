using AutoSchool.Domain.Enums;

namespace AutoSchool.Domain.Entities;

public sealed class GIBDDExam : BaseEntity
{
    public long StudentId { get; set; }
    public ExamTypeEnum ExamType { get; set; }
    public DateTimeOffset date { get; set; }
    public bool Result { get; set; }
    public required string InspectorName { get; set; }
}
