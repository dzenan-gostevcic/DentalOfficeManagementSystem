using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicoDent.Domain.Entities
{
    public partial class PatientContact 
    {
        public int Id { get; set; } 
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public string? StreetName { get; set; }
        public string? StreetNumber { get; set; }
        public string? PostalCode { get; set; }
        public string? City { get; set;}
        public string? Country { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }
}
