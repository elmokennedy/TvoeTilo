using TvoeTilo.Domain.Entities;
using TvoeTilo.Infrastructure.DataAccess.Repositories;

namespace TvoeTilo.Infrastructure.Services
{
    public class ClientService : IClientService
    {
        public IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<IEnumerable<Client>> GetAllAsync()
        {
            return await _clientRepository.GetAllAsync();
        }

        public async Task Create(Client client)
        {
            await _clientRepository.Create(client);
        }
    }
}
