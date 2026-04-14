namespace MedicoDent.Application.DTOs
{
    public class PacijentDto
    {
        public int Id { get; set; }
        public bool IsBlackListed { get; set; }
        public bool HasAllergie { get; set; }

        // -----------------------------
        // BASIC INFO
        // -----------------------------
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? IdNumber { get; set; }
        public string? IdentityValue { get; set; }
        public string? AlarmStatus { get; set; }
        public string? MarriageStatus { get; set; }
        public string? BirthPlace { get; set; }
        public string? SocialSecurityNumber { get; set; }
        public string? Parent { get; set; }
        public string? HealthInsuranceNumber { get; set; }
        public string? AdditionalHealthInsuranceNumber { get; set; }
        public string? Occupation { get; set; }
        public string? Workplace { get; set; }
        public string? Group { get; set; }

        // -----------------------------
        // CONTACT INFO
        // -----------------------------
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }

        // -----------------------------
        // ALARMS
        // -----------------------------
        public string? AdditionalNote { get; set; }
    }
}
