using PharmacyManagementWebAPI.Models;

namespace PharmacyManagementWebAPI.Data
{
    public class Orders
    {
        public int OrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public bool IsPickedUp { get; set; } = false;
        public int Amount { get; set; }
        public int Count { get; set; }
        public Doctor Doctor { get; set; }
        public int DoctorId { get; set; }
        public int MedicineId { get; set; }
        public string MedName { get; set; }
        public int MedPrice { get; set; }
        public ICollection<Medicine> Medicines { get; set; }
        public Admin Admin { get; set; }
        public int AdminId { get; set; }
    }
}
