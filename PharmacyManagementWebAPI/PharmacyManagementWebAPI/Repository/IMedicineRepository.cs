using PharmacyManagementWebAPI.Models;

namespace PharmacyManagementWebAPI.Repository
{
    public interface IMedicineRepository
    {
       Task<List<Medicine>> GetAllMedicines();
    }
}
