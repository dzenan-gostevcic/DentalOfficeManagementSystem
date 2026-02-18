using System.ComponentModel.DataAnnotations;

namespace MedicoDent.Domain.Entities
{
    public class PatientGroupTemplate
    {
        [Key]
        public int Id { get; set; }
        public string? TemplateText { get; set; }
    }
}
