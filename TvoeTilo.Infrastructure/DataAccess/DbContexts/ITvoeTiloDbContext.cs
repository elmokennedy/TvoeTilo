using Microsoft.EntityFrameworkCore;
using TvoeTilo.Domain.Entities;

namespace TvoeTilo.Infrastructure.DataAccess.DbContexts
{
    public interface ITvoeTiloDbContext
    {
        DbSet<Client> Clients { get; set; }

        Task SaveChangesAsync();
    }
}
