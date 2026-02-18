using System.ComponentModel.DataAnnotations;

namespace MedicoDent.Domain.Entities
{
    public class MedicoService
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
