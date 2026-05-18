namespace AutoSchool.Domain.Entities;

public sealed class ExamResult : BaseEntity
{
   public long ExamId { get; set; }
   public long StudentId { get; set; }
   public byte Score { get; set; }
   public byte MistakesCount { get; set; }
   public long InstructorId { get; set; }
   public required string Notes { get; set; }
}
