using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductCRUDAPI.Models;

namespace ProductCRUDAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductDBContext _dbContext;

        public ProductsController(ProductDBContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _dbContext.Products.ToListAsync();
        }
  
    }
}
