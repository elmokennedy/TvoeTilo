using TvoeTilo.Domain.Entities;

namespace TvoeTilo.Infrastructure.Services
{
    public interface IClientService
    {
        Task<IEnumerable<Client>> GetAllAsync();

        Task Create(Client client);
    }
}
