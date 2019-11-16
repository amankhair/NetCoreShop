using Microsoft.EntityFrameworkCore;
using NetCoreShop.Web.Data.Entities;

namespace NetCoreShop.Web.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
    }
}
