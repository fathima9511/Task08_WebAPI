using Microsoft.EntityFrameworkCore;
using Task08_WebAPI.Model;

namespace Task08_WebAPI.Data
{
    public class ProductAPIDbContext : DbContext
    {
        public ProductAPIDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
    }
}
