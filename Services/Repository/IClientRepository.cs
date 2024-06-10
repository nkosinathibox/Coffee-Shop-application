using Coffee_Shop_application.Domain;

namespace Coffee_Shop_application.Services.Repository
{
    public interface IClientRepository
    {
        Task<Client> GetClientByIdAsync(int clientId);
        Task<IEnumerable<Client>> GetAllClientsAsync();
        Task AddPurchaseAsync(Purchase purchase);
    }
}
