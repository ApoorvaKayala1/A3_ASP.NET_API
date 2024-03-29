﻿using Microsoft.AspNetCore.Mvc;
using Web_Assignment3.Models;
using Web_Assignment3.Repositories;

namespace Web_Assignment3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CartController : ControllerBase
    {
        private readonly ICartRepository _cartRepository;

        public CartController(ICartRepository cartRepository)
        {
            _cartRepository = cartRepository;
        }

        [HttpGet]
        public IActionResult GetAllItems()
        {
            // Perform inner join to retrieve cart data with additional product information
            var items = _cartRepository.GetAllItemsWithProductInfo();
            return Ok(items);
        }

        [HttpGet("{id}")]
        public IActionResult GetItemById(int id)
        {
            var item = _cartRepository.GetItemById(id);
            if (item == null)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IActionResult AddItem(Cart item)
        {
            _cartRepository.AddItem(item);
            return CreatedAtAction(nameof(GetItemById), new { id = item.Id }, item);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateItem(int id, Cart item)
        {
            if (id != item.Id)
            {
                return BadRequest();
            }
            _cartRepository.UpdateItem(item);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteItem(int id)
        {
            _cartRepository.DeleteItem(id);
            return NoContent();
        }

        [HttpDelete]
        public IActionResult DeleteAllItems()
        {
            try
            {
                _cartRepository.DeleteAllItems(); // Call method to delete all items from the cart
                return Ok(new { message = "All items deleted from the cart." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { error = "An error occurred while deleting items from the cart.", details = ex.Message });
            }
        }
    }
}
