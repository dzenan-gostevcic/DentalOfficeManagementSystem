namespace MedicoDent.Application.DTOs
{
    public class UpdatePacijentDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public bool IsBlackListed { get; set; }
        public bool HasAllergie { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
