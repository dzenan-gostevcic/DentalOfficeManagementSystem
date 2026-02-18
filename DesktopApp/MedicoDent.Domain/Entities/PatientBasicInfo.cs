namespace MedicoDent.Domain.Entities
{
    public class PatientBasicInfo
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? IdNumber { get; set; }
        public string? IdentityValue { get; set; }
        public string? MarriageStatus { get; set; }
        public string? Occupation { get; set; }
        public string? Workplace { get; set; }
    }
}
