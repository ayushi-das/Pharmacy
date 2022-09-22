using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace PharmacyManagementWebAPI.Models
{
    public class Medicine
    {
        
        public int MedicineId { get; set; }
        public string MedName { get; set; }
        public int MedPrice { get; set; }
        public DateTime MedExpDate { get; set; }
        public int MedStock { get; set; }

        //public int? OrderId { get; set; }
        //[ValidateNever]
        //public virtual Order Order { get; set; }
    }
}
