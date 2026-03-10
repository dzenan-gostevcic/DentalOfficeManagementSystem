using System.ComponentModel.DataAnnotations;

namespace MedicoDent.Domain.Entities
{
    public class Patient : DatesInfo
    {
        [Key]
        public int Id { get; set; }

        public PatientBasicInfo? PatientBasicInfo { get; set; }
        public PatientContact? PatientContact {  get; set; }

        public bool IsBlackListed { get; set; }
        public bool HasAllergie { get; set; }

        public ICollection<PatientGroupMembership>? PatientGroupsMembership { get; set; }
        public ICollection<PatientAllergies>? PatientAllergies { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeleteDate { get; set; }

        public bool IsDeleted { get; set; } = false;
    }
}
