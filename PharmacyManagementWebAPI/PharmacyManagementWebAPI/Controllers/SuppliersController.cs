using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PharmacyManagementWebAPI.Models;
using PharmacyManagementWebAPI.Repository;

namespace PharmacyManagementWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;
        public SuppliersController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllSuppliers()
        {
            var suppliers = await _supplierRepository.GetAllSuppliers();
            return Ok(suppliers);
        }
        [HttpPost("")]
        public async Task<IActionResult> AddSupplier([FromBody] Supplier supplier)
        {
            var id = await _supplierRepository.AddSupplier(supplier);
            return CreatedAtAction(nameof(AddSupplier), id);

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateSupplier([FromBody] Supplier supplier, [FromRoute] int id)
        {
            await _supplierRepository.UpdateSupplier(id, supplier);
            return Ok();

        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier([FromRoute] int id)
        {
            await _supplierRepository.DeleteSupplier(id);
            return Ok();
        }
    }
}
