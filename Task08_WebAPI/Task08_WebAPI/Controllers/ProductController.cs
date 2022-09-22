using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task08_WebAPI.Data;
using Task08_WebAPI.Model;

namespace Task08_WebAPI.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly ProductAPIDbContext dbcontext;

        public ProductController(ProductAPIDbContext dbContext)
        {
            this.dbcontext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            return Ok(await dbcontext.Products.ToListAsync());
        }


        [HttpGet]
        [Route("{id:guid}")]

        public async Task<IActionResult> GetProduct([FromRoute] Guid id)
        {
            var product = await dbcontext.Products.FindAsync(id);

            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }




        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductRequest addProductRequest)

        {
            var product = new Product()
            {
                Id = Guid.NewGuid(),
                ProductName = addProductRequest.ProductName,
                Availability = addProductRequest.Availability,
                Brand = addProductRequest.Brand,
                Quantity = addProductRequest.Quantity,
                Price = addProductRequest.Price

            };
            await dbcontext.Products.AddAsync(product);
            await dbcontext.SaveChangesAsync();

            return Ok(product);

        }

        [HttpPut]
        [Route("{id:guid}")]

        public async Task<IActionResult> UpdateProduct([FromRoute] Guid id, UpdateProductRequest updateProductRequest)
        {
            var product = dbcontext.Products.Find(id);

            if (product != null)
            {
               product.ProductName = updateProductRequest.ProductName;
                product.Availability = updateProductRequest.Availability;
                product.Brand = updateProductRequest.Brand;
                product.Quantity = updateProductRequest.Quantity;
                product.Price = updateProductRequest.Price;

                await dbcontext.SaveChangesAsync();
                return Ok(product);
            }
            return NotFound();

        }

        [HttpDelete]
        [Route("{id:guid}")]

        public async Task<IActionResult> DeleteProduct([FromRoute] Guid id)
        {
            var product = await dbcontext.Products.FindAsync(id);

            if (product != null)
            {
                dbcontext.Remove(product);
                await dbcontext.SaveChangesAsync();
                return Ok(product);
            }

            return NotFound();
        }

    }

}
