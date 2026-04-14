namespace MedicoDent.Application.DTOs
{
    public class PacijentListItemDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; } = "";
        public string? LastName { get; set; } = "";

        public string? Phone { get; set; } = "";
        public bool? HasAllergie { get; set; }
        public bool? IsBlackListed { get; set; }
        public DateTime? BirthDate { get; set; }

        public string? Email { get; set; } = "";
        public string? City { get; set; } = "";
       public string? Street { get; set; } = "";
        public string? PostalCode { get; set; } = "";
        public string? Gender { get; set; } = "";
        public string? BirthPlace { get; set; } = "";
        public string? Parent { get; set; } = "";
        public int? JMB { get; set; }
        public string? IDCardNumber { get; set; } = "";
        public string? HealthInsuranceNumber { get; set; } = "";
        public string? HealthInsuranceAdditionalNumber { get; set; } = "";
        public string? MarriageStatus { get; set; } = "";
        public string? Job { get; set; } = "";

        public string FullName => $"{FirstName} {LastName}".Trim();
    }
}
