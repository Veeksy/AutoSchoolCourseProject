using AutoSchool.Domain.Enums;

namespace AutoSchool.Domain.Entities;

public sealed class Instructor : BaseEntity
{
    public required string LicenseNumber { get; set; }
    public required DateTimeOffset LicenseIssueDate { get; set; }
    public required DateTimeOffset LicenseExpiryDate { get; set; }
    public required int DrivingExperienceYears { get; set; }
    public TransmissionTypeEnum TransmissionType { get; set; }
    public long? CarId { get; set; }
}
