using PharmacyManagementWebAPI.Models;

namespace PharmacyManagementWebAPI.Repository
{
    public interface IOrderRepository
    {
        Task<List<Order>> GetAllOrders();
        Task<int> AddOrder(Order order);
    }
}
