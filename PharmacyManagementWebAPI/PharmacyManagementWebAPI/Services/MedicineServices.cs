using Microsoft.EntityFrameworkCore;
using PharmacyManagementWebAPI.Models;
using PharmacyManagementWebAPI.Repository;

namespace PharmacyManagementWebAPI.Services
{
    public class MedicineServices:IMedicineRepository
    {
        private readonly PharmacyDbContext _context;

        public MedicineServices (PharmacyDbContext context)
        {
            _context = context;
        }
        public async Task<List<Medicine>> GetAllMedicines()
        {
            var records = await _context.Medicines.Select(x => new Medicine()
            {
                MedicineId = x.MedicineId,
                MedName=x.MedName,
                MedExpDate=x.MedExpDate,
                MedPrice=x.MedPrice,
                MedStock=x.MedStock,

            }).ToListAsync();
            return records;
        }
    }
}
