namespace AutoSchool.Domain.Entities;

public sealed class User : BaseEntity
{
    public long Role { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public required string PasswordHash { get; set; }
    public long isActive { get; set; }
}
