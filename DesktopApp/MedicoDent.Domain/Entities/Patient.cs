using System.ComponentModel.DataAnnotations;

namespace MedicoDent.Domain.Entities
{
    public class Patient : DatesInfo
    {
        [Key]
        public int Id { get; set; }

        public PatientBasicInfo? PatientBasicInfo { get; set; }
        public PatientContact? PatientContact {  get; set; }

        public bool IsOnBlackList { get; set; }
        public bool HasAllergie { get; set; }

        public List<PatientGroups>? PatientGroups { get; set; }
        public List<Allergie>? Allergies { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
