using Web_Assignment3.Models;

namespace Web_Assignment3.Repositories
{
    public interface ICartRepository
    {
        IEnumerable<Cart> GetAllItems();
        Cart GetItemById(int id);
        void AddItem(Cart item);
        void UpdateItem(Cart item);
        void DeleteItem(int id);
    }
}
