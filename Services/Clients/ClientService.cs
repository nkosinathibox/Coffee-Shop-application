using Coffee_Shop_application.Domain;
using Coffee_Shop_application.Models;
using Coffee_Shop_application.Services.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coffee_Shop_application.Services.Clients
{
    public class ClientService
    {
        private readonly IClientRepository _clientRepository;

        public ClientService(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public async Task<ClientDto> GetClientByIdAsync(int id)
        {
            var client = await _clientRepository.GetClientByIdAsync(id);
            if (client == null)
                return null;

            return new ClientDto
            {
                ClientId = client.ClientId,
                Name = client.Name,
                Points = client.Points
                // Include other properties as needed
            };
        }

        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await _clientRepository.GetAllClientsAsync();
        }

        public async Task AddPurchaseAsync(PurchaseDto purchase)
        {
            // Map PurchaseDto to Purchase entity
            var purchaseEntity = new Purchase
            {
                // Map properties accordingly
                ClientId = purchase.ClientId,
                PurchaseId = purchase.PurchaseId,
                PurchaseDate = purchase.PurchaseDate,
                // Include other properties as needed
            };

            await _clientRepository.AddPurchaseAsync(purchaseEntity);
        }

        public decimal ConvertPointsToCash(int points)
        {
            return points * 0.1m; // Example conversion rate: 1 point = $0.10
        }
    }
}
