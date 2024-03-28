using Web_Assignment3.Models;

namespace Web_Assignment3.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();

        Order GetOrderById(int id);

        void AddOrder(Order order);

        void UpdateOrder(Order order);

        void DeleteOrder(int id);
    }
}
