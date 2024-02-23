using Microsoft.AspNetCore.Mvc;
using TvoeTilo.Domain.Entities;
using TvoeTilo.Infrastructure.Services;

namespace TvoeTilo.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {
        public IClientService _clientService;

        public ClientController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var clients = await _clientService.GetAllAsync();
            return StatusCode(StatusCodes.Status200OK, clients);
        }

        [HttpPost]
        public async Task<IActionResult> Create(Client client)
        {
            await _clientService.Create(client);
            return StatusCode(StatusCodes.Status200OK);
        }
    }
}
