using Microsoft.EntityFrameworkCore;
using PharmacyManagementWebAPI.Data;
using PharmacyManagementWebAPI.Models;
using PharmacyManagementWebAPI.Repository;
using System.Collections;

namespace PharmacyManagementWebAPI.Services
{
    public class OrderServices : IOrderRepository
    {
        private readonly PharmacyDbContext _context;

        public OrderServices(PharmacyDbContext context)
        {
            _context = context;
        }

        public async Task<List<Order>> GetAllOrders()
        {
            var records = await _context.Orders.Select(o => new Order()
            {
                OrderDate = o.OrderDate,
                OrderId = o.OrderId,
                Amount = o.Amount,
                Count = o.Count,
                IsPickedUp = o.IsPickedUp,
                Admin = o.Admin,
                AdminId = o.AdminId,
                Medicines = o.Medicines.ToList(),
                Doctor = o.Doctor,
                DoctorId = o.DoctorId,
            }).ToListAsync();

            return records;

        }
        public async Task<int> AddOrder(Order order)
        {

            var record = new Order()
            {
                OrderId = order.OrderId,
                OrderDate = order.OrderDate,
                Amount = order.Amount,
                Count = order.Count,
                // Admin = order.Admin,
                AdminId = order.AdminId,
                // Doctor= order.Doctor,
                DoctorId = order.DoctorId,
                //MedicineId = order.MedicineId,
                Medicines = order.Medicines.ToList<Medicine>()
                
                };
           
                _context.Orders.Add(record);
                await _context.SaveChangesAsync();
                return record.OrderId;
            
                
          

        }

       
    }
}
