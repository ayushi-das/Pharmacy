namespace PharmacyManagementWebAPI.Models
{
    public class SalesReport
    {
        public int SalesId { get; set; }
        public Admin Admin { get; set; }
        public int AdminId { get; set; }
        public Doctor Doctor { get; set; }
        public int DocId { get; set; }
        public Medicine Medicine { get; set; }
        public int MedId { get; set; }
        public Order Order { get; set; }    
        public int OrderId { get; set; }
        public int TotalAmount { get; set; }
        public DateTime SalesDate { get; set; }
    }
}
