namespace MedicoDent.Application.DTOs
{
    public class PacijentDto
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public int? Phone { get; set; }

    }
}
