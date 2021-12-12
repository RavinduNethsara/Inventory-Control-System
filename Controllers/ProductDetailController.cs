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
    public class ProductDetailController : ControllerBase
    {

        private readonly ProductDetailContext _context;

        public ProductDetailController(ProductDetailContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            return await _context.Product.ToListAsync();
        }

        // GET:
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProductDetails(int id)
        {
            var productDetail = await _context.Product.FindAsync(id);

            if (productDetail == null)
            {
                return NotFound();
            }

            return productDetail;
        }

        // PUT:
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProductDetails(int id, Product productDetail)
        {
            if (id != productDetail.productID)
            {
                return BadRequest();
            }

            _context.Entry(productDetail).State = EntityState.Modified;

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

        // POST:
        [HttpPost]
        public async Task<ActionResult<Product>> AddProductDetail(Product productDetail)
        {
            _context.Product.Add(productDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductDetail", new { id = productDetail.productID }, productDetail);
        }

        // DELETE:
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductDetail(int id)
        {
            var productDetail = await _context.Product.FindAsync(id);
            if (productDetail == null)
            {
                return NotFound();
            }

            _context.Product.Remove(productDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CategoryDetailExists(int id)
        {
            return _context.Product.Any(e => e.productID == id);
        }



    }


}

