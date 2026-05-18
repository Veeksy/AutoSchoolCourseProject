namespace AutoSchool.Domain.Entities;

public abstract class BaseEntity
{
    public long Id { get; set; }

    public DateTimeOffset Created { get; set; }
    public DateTimeOffset LastModified { get; set; }
}
