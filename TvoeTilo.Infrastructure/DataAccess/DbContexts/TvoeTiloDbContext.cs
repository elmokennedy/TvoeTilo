using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using TvoeTilo.Domain.Entities;

namespace TvoeTilo.Infrastructure.DataAccess.DbContexts
{
    public class TvoeTiloDbContext : DbContext, ITvoeTiloDbContext
    {
        public DbSet<Client> Clients { get; set; }

        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(LocalDb)\\MSSQLLocalDB;Database=TvoeTilo;");
            }
        }
    }
}
