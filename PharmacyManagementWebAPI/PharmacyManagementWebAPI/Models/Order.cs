using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementWebAPI.Models
{
    public class Order
    {
        
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPickedUp { get; set; } = false;
        public int Amount { get; set; }
        public int Count { get; set; }
        public int DoctorId { get; set; }
        public int AdminId { get; set; }
        public int MedicineId { get; set; }
        
        [ValidateNever]
        public Doctor Doctor { get; set; }
        [ValidateNever]
        public Admin Admin { get; set; }
        [ValidateNever]
       // public ICollection<Medicine> Medicines { get; set; }
       public Medicine Medicine { get; set; }
       
    }
}
