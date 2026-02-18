using System.ComponentModel.DataAnnotations;

namespace MedicoDent.Domain.Entities
{
    public class Allergie
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Notes { get; set; }
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }

        public bool? HasVagina { get; set; }

    }
}
