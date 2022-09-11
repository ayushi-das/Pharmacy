namespace PharmacyManagementWebAPI.Models
{
    public class Medicine
    {
        public int MedId { get; set; }
        public string MedName { get; set; }
        public int MedPrice { get; set; }
        public DateTime MedExpDate { get; set; }
        public int MedStock { get; set; }
    }
}
