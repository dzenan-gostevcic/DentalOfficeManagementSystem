namespace MedicoDent.Application.DTOs
{
    public class PacijentListItemDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }

        public string FullName => $"{FirstName} {LastName}".Trim();
    }
}
