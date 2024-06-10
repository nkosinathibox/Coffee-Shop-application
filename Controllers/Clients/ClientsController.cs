using Coffee_Shop_application.Models;
using Coffee_Shop_application.Services.Clients;
using Microsoft.AspNetCore.Mvc;

namespace Coffee_Shop_application.Controllers.Clients
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        private readonly IClientService _clientService;

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ClientDto>> GetClientById(int id)
        {
            var client = await _clientService.GetClientByIdAsync(id);
            if (client == null)
            {
                return NotFound();
            }
            return Ok(client);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ClientDto>>> GetAllClients()
        {
            var clients = await _clientService.GetAllClientsAsync();
            return Ok(clients);
        }

        [HttpPost("purchase")]
        public async Task<ActionResult> AddPurchase(PurchaseDto purchase)
        {
            await _clientService.AddPurchaseAsync(purchase);
            return Ok();
        }

        [HttpGet("convert/{points}")]
        public ActionResult<decimal> ConvertPointsToCash(int points)
        {
            var cashValue = _clientService.ConvertPointsToCash(points);
            return Ok(cashValue);
        }
    }

}
