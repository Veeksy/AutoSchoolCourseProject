using AutoSchool.Domain.Enums;

namespace AutoSchool.Domain.Entities;

/// <summary>
/// Зачисления
/// </summary>
public sealed class Enrollment : BaseEntity
{
    public long StudentId { get; set; }
    public long CourseId { get; set; }
    public DateTimeOffset EnrollmentDate { get; set; }
    public StudentStatusEnum Status { get; set; }
        
}
