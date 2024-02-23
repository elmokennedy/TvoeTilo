using TvoeTilo.Domain.Entities;

namespace TvoeTilo.Infrastructure.DataAccess.Repositories
{
    public interface IClientRepository
    {
        Task<IEnumerable<Client>> GetAllAsync();

        Task Create(Client client);
    }
}
