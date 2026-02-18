using System.ComponentModel.DataAnnotations;

namespace MedicoDent.Domain.Entities
{
    public class Treatment
    {
        [Key]
        public int Id { get; set; } 
        public DateTime? TreatmentDate {  get; set; }
        public string? Time { get; set; }
        public bool IsFullDay { get; set; }
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public int ServiceId { get; set; }
        public MedicoService? Service { get; set; }
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public string? Notes { get; set; }

    }
}
