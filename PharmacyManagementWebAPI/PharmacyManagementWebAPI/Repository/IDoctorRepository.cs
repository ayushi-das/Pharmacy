using PharmacyManagementWebAPI.Models;

namespace PharmacyManagementWebAPI.Repository
{
    public interface IDoctorRepository
    {
        Task<List<Doctor>> GetAllDoctors();
        Task<Doctor> GetDoctorByName(string DocName);
        Task<int> AddDoctor(Doctor doctor);
        Task DeleteDoctor(int id);
    }
}
