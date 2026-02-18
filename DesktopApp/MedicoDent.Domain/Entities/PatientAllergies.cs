namespace MedicoDent.Domain.Entities
{
    public class PatientAllergies
    {
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public int AllergieId { get; set; }
        public Allergie? Allergie { get; set; }
    }
}
