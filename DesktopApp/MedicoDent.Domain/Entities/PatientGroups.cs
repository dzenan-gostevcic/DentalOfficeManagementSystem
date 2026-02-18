namespace MedicoDent.Domain.Entities
{
    public class PatientGroups
    {
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public int GroupId { get; set; }
        public PatientGroup? PatientGroup { get; set; }

        public int? TemplateId { get; set; }
        public PatientGroupTemplate? PatientGroupTemplate { get; set; }
    }
}
