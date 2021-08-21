using Core.Entites;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class StoreContext : DbContext
    {
        public StoreContext(DbContextOptions<StoreContext> option) : base(option)
        {
            
        } 
        public DbSet<Product> Products { get; set; }
        
    }
}