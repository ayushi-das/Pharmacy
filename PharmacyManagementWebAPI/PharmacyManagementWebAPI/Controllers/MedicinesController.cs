using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PharmacyManagementWebAPI.Models;
using PharmacyManagementWebAPI.Repository;

namespace PharmacyManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicinesController : ControllerBase
    {
        //private readonly PharmacyDbContext _pharmacyDbContext;
        //public MedicinesController(PharmacyDbContext pharmacyDbContext)
        //{
        //    _pharmacyDbContext = pharmacyDbContext;
        //}
        //[HttpGet]
        //public async Task<IActionResult> GetAllMedicines()
        //{
        //    var meds = await _pharmacyDbContext.Medicines.ToListAsync();
        //    return Ok(meds);
        //}
        private readonly IMedicineRepository _medicineRepository;
        public MedicinesController(IMedicineRepository medicineRepository)
        {
            _medicineRepository = medicineRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMedicines()
        {
            var medicines = await _medicineRepository.GetAllMedicines();
            return Ok(medicines);
        }

    }
}
