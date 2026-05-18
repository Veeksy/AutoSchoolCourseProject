namespace AutoSchool.Domain.Entities;

public sealed class Category : BaseEntity
{
    public required string Name { get; set; }
    public string? Description { get; set; }
    public int TheoryHours { get; set; }
    public int PracticeHours { get; set; }
}
