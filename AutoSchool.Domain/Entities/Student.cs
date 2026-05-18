namespace AutoSchool.Domain.Entities;

public sealed class Student : BaseEntity
{
    public required DateTimeOffset Bithday { get; set; }
    public string? Address { get; set; }
    public required string MedicalCertificateNumber { get; set; }
    public required DateTimeOffset MedicalCertificateIssueDate { get; set; }
    public required DateTimeOffset MedicalCertificateExpiryDate { get; set; }
    public required string PassportSeries { get; set; }
    public required string PassportNumber { get; set; }
    public required string PassportIssuedBy { get; set; }
    public required string PassportIssueDate { get; set; }
    public bool IsTheoryPassed { get; set; }
    public bool IsInternalExamPassed { get; set; }
}
