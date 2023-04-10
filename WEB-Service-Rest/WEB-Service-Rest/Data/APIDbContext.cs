using Microsoft.EntityFrameworkCore;
using WEB_Service_Rest.Models;

namespace WEB_Service_Rest.Data
{
    public class APIDbContext : DbContext
    {
        public APIDbContext(DbContextOptions<APIDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Conta> Conta { get; set; }
        public DbSet<Saldo> Saldo { get; set; }
    }
}
