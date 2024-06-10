using Coffee_Shop_application.Domain;
using Coffee_Shop_application.Models;

namespace Coffee_Shop_application.Services.Clients
{
    public interface IClientService
    {
        Task<Client> GetClientByIdAsync(int clientId);
        Task<IEnumerable<ClientDto>> GetAllClientsAsync();
        Task AddPurchaseAsync(PurchaseDto purchase);
        decimal ConvertPointsToCash(int points);
    }
}
