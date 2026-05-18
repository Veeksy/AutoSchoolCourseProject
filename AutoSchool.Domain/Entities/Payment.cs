using AutoSchool.Domain.Enums;

namespace AutoSchool.Domain.Entities;

public sealed class Payment : BaseEntity
{
    public long StudentId { get; set; }
    public long CourseId { get; set; }
    public decimal Amount { get; set; }
    public DateTimeOffset PaymentDate { get; set; }
    public string? Purpose { get; set; }
    public PaymentStatusEnum Status { get; set; }
}
