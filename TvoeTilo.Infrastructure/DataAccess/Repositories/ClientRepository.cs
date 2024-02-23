using Microsoft.EntityFrameworkCore;
using TvoeTilo.Domain.Entities;
using TvoeTilo.Infrastructure.DataAccess.DbContexts;

namespace TvoeTilo.Infrastructure.DataAccess.Repositories
{
    public class ClientRepository : IClientRepository
    {
        private readonly ITvoeTiloDbContext _tvoeTiloDbContext;

        public ClientRepository(ITvoeTiloDbContext tvoeTiloDbContext)
        {
            _tvoeTiloDbContext = tvoeTiloDbContext;
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _tvoeTiloDbContext.Clients.ToListAsync();
        }

        public async Task Create(Client client)
        {
            await _tvoeTiloDbContext.Clients.AddAsync(client);
            await _tvoeTiloDbContext.SaveChangesAsync();
        }
    }
}
