using InventoryControlSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InventoryControlSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductCategoryController : ControllerBase
    {
        private readonly ProductDetailContext _context;

        public ProductCategoryController(ProductDetailContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductCategory>>> GetProductCategories()
        {
            return await _context.ProductCategory.ToListAsync();
        }

        // GET: api/Categories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductCategory>> GetCategoryDetails(int id)
        {
            var categoryDetail = await _context.ProductCategory.FindAsync(id);

            if (categoryDetail == null)
            {
                return NotFound();
            }

            return categoryDetail;
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategoryDetails(int id, ProductCategory categoryDetail)
        {
            if (id != categoryDetail.categoryID)
            {
                return BadRequest();
            }

            _context.Entry(categoryDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CategoryDetailExists(id))
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

        // POST: api/Categories
        [HttpPost]
        public async Task<ActionResult<ProductCategory>> AddCategoryDetail(ProductCategory categoryDetail)
        {
            _context.ProductCategory.Add(categoryDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductDetail", new { id = categoryDetail.categoryID }, categoryDetail);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryDetail(int id)
        {
            var categoryDetail = await _context.ProductCategory.FindAsync(id);
            if (categoryDetail == null)
            {
                return NotFound();
            }

            _context.ProductCategory.Remove(categoryDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryDetailExists(int id)
        {
            return _context.ProductCategory.Any(e => e.categoryID == id);
        }
    }
}
