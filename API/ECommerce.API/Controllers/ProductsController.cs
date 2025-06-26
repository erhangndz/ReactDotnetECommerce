using ECommerce.API.Data;
using ECommerce.API.DTOs;
using ECommerce.API.Entities;
using Mapster;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController(AppDbContext context) : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetAll()
        {
            var products = await context.Products.AsNoTracking().ToListAsync();
            return Ok(products);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetById(int id)
        {
            var product = await context.Products.FindAsync(id);
            if (product is null)
            {
                return BadRequest("Product Not Found");
            }
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateProductDto productDto)
        {
            var product = productDto.Adapt<Product>();
            context.Add(product);
            await context.SaveChangesAsync();
            return Ok(product);
        }

        [HttpPut]
        public async Task<IActionResult> Update(UpdateProductDto productDto)
        {
            var product = productDto.Adapt<Product>();
            var updateProduct = await context.Products.FindAsync(product.Id);
            if (updateProduct is null)
            {
                return BadRequest("Product Not Found");
            }
            context.Update(updateProduct);
            await context.SaveChangesAsync();
            return Ok(product);
        }
    }
}
