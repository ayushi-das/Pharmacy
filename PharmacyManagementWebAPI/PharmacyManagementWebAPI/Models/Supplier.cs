using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PharmacyManagementWebAPI.Models
{
    public class Supplier
    {
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string SupplierEmail { get; set; }
        public Medicine Medicine { get; set; }
        public int MedicineId { get; set; }
        public int MedPrice { get; set; }
        public DateTime MedExpDate { get; set; }

    }
}
