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
    }
}
