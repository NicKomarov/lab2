using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodOrderAPIWebApp.Models;

namespace FoodOrderAPIWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuProductsController : ControllerBase
    {
        private readonly FoodOrderAPIContext _context;

        public MenuProductsController(FoodOrderAPIContext context)
        {
            _context = context;
        }

        // GET: api/MenuProducts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MenuProduct>>> GetMenuProducts()
        {
          if (_context.MenuProducts == null)
          {
              return NotFound();
          }
            return await _context.MenuProducts.ToListAsync();
        }

        // GET: api/MenuProducts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MenuProduct>> GetMenuProduct(int id)
        {
          if (_context.MenuProducts == null)
          {
              return NotFound();
          }
            var menuProduct = await _context.MenuProducts.FindAsync(id);

            if (menuProduct == null)
            {
                return NotFound();
            }

            return menuProduct;
        }

        // PUT: api/MenuProducts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMenuProduct(int id, MenuProduct menuProduct)
        {
            if (id != menuProduct.Id)
            {
                return BadRequest();
            }

            _context.Entry(menuProduct).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenuProductExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/MenuProducts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<MenuProduct>> PostMenuProduct(MenuProduct menuProduct)
        {
          if (_context.MenuProducts == null)
          {
              return Problem("Entity set 'FoodOrderAPIContext.MenuProducts'  is null.");
          }
            _context.MenuProducts.Add(menuProduct);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMenuProduct", new { id = menuProduct.Id }, menuProduct);
        }

        // DELETE: api/MenuProducts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMenuProduct(int id)
        {
            if (_context.MenuProducts == null)
            {
                return NotFound();
            }
            var menuProduct = await _context.MenuProducts.FindAsync(id);
            if (menuProduct == null)
            {
                return NotFound();
            }

            _context.MenuProducts.Remove(menuProduct);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenuProductExists(int id)
        {
            return (_context.MenuProducts?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
