using Microsoft.AspNetCore.JsonPatch;
using PharmacyManagementWebAPI.Models;

namespace PharmacyManagementWebAPI.Repository
{
    public interface IMedicineRepository
    {
       Task<List<Medicine>> GetAllMedicines();
        Task<Medicine> GetMedicineByName(string MedName);
        Task<int> AddMedicine(Medicine medicine);
        Task UpdateMedicine(int id, Medicine medicine);
        Task UpdateMedicineByStock(int id, JsonPatchDocument medicine);
        Task DeleteMedicine(int id);


    }
}
