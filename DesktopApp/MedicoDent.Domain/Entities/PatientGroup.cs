using System.ComponentModel.DataAnnotations;

namespace MedicoDent.Domain.Entities
{
    public class PatientGroup
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public List<PatientGroups>? PatientGroups { get; set; }

    }
}
