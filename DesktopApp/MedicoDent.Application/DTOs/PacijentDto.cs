namespace MedicoDent.Application.DTOs
{
    public class PacijentDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public String? Phone { get; set; }
        public bool IsBlackListed { get; set; }
        public bool HasAllergie { get; set; }
    }
}
