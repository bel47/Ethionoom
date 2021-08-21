using Core.Entites;
using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly StoreContext _storeContext;
        public ProductsController(StoreContext storeContext)
        {
            _storeContext = storeContext;
        }

        [HttpGet]
       public async Task<ActionResult<List<Product>>> GetProducts()
       {
            var product = await _storeContext.Products.ToListAsync();
           return Ok(product);
       }
       [HttpGet("{id}")]
       public async Task<ActionResult<Product>> GetProduct(int id)
       {
           var product = await _storeContext.Products.FirstAsync();
            return product;
       }
    }
}