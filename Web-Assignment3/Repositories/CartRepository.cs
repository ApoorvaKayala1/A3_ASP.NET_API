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
    }
}
