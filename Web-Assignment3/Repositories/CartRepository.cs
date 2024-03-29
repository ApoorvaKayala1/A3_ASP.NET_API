using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Web_Assignment3.Models;

namespace Web_Assignment3.Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly AppDbContext _context;

        public CartRepository(AppDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Cart> GetAllItems()
        {
            return _context.Cart.ToList();
        }

        public Cart GetItemById(int id)
        {
            return _context.Cart.Find(id);
        }

        public void AddItem(Cart item)
        {
            _context.Cart.Add(item);
            _context.SaveChanges();
        }

        public void UpdateItem(Cart item)
        {
            _context.Entry(item).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            var item = _context.Cart.Find(id);
            if (item != null)
            {
                _context.Cart.Remove(item);
                _context.SaveChanges();
            }
        }

        public void DeleteAllItems()
        {
            try
            {
                _context.Cart.RemoveRange(_context.Cart); // Remove all items from the Cart table
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting all items from the cart.", ex);
            }
        }

        public IEnumerable<CartWithProductInfo> GetAllItemsWithProductInfo()
        {
            return _context.Cart
                .Join(_context.Products,
                    cartItem => cartItem.Product_Id,
                    product => product.Id,
                    (cartItem, product) => new CartWithProductInfo
                    {
                        Id = cartItem.Id,
                        UserId = cartItem.User_Id, 
                        ProductId = cartItem.Product_Id,
                        Quantity = cartItem.Quantity,
                        ProductName = product.Name,
                        ProductImage = product.Image,
                        ProductPricing = product.Pricing
                    })
                .ToList();
        }
    }
}
