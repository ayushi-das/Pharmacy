using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
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
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public Admin Admin { get; set; }
        public int AdminId { get; set; }

        
        
    }
}
