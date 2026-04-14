namespace MedicoDent.Application.DTOs.Allergie
{
    public class PatientAllergieDto
    {
        public int PatientId { get; set; }

        public int AllergieId { get; set; }

        public string? AllergieName { get; set; }

        public string? AdditionalNote { get; set; }
    }
}