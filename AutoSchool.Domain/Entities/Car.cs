using AutoSchool.Domain.Enums;

namespace AutoSchool.Domain.Entities;

public sealed class Car : BaseEntity
{
    public required string Brand { get; set; }
    public required string Model { get; set; }
    public int Year { get; set; }
    public required string PlateNumber { get; set; }
    public required string Vin { get; set; }
    public TransmissionTypeEnum TransmissionType { get; set; }
    public CarStateEnum Status { get; set; }
}
