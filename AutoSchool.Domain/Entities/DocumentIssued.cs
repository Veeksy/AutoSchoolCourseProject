namespace AutoSchool.Domain.Entities;

public sealed class DocumentIssued : BaseEntity
{
    public long StudentId { get; set; }
    public required string Number { get; set; }
    public DateTimeOffset IssueDate { get; set; }
}
