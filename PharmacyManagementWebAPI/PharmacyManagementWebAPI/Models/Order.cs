namespace PharmacyManagementWebAPI.Models
{
    public class Order
    {
        public int OrderId { get; set; } 
        public Doctor Doctor { get; set; }
        public int DocId { get; set; }
        public Medicine Medicine { get; set; }
        public int MedId { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
