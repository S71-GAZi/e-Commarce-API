using e_Commarce_API.Models;
using Microsoft.EntityFrameworkCore;

namespace e_Commarce_API.DataContext
{
    public class ApiContext : DbContext 
    {
        public ApiContext(DbContextOptions<ApiContext> options) : base(options)
        {


        }
        public DbSet<User> Users { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Subcategory> Subcategories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
