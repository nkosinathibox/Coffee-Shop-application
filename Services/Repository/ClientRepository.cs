using Coffee_Shop_application.Context;
using Coffee_Shop_application.Domain;
using Microsoft.EntityFrameworkCore;

namespace Coffee_Shop_application.Services.Repository
{
    public class ClientRepository : IClientRepository
    {
        private readonly CoffeeShopContext _context;

        public ClientRepository(CoffeeShopContext context)
        {
            _context = context;
        }

        public async Task<Client> GetClientByIdAsync(int clientId)
        {
            return await _context.Clients.Include(c => c.Purchases).FirstOrDefaultAsync(c => c.ClientId == clientId);
        }

        public async Task<IEnumerable<Client>> GetAllClientsAsync()
        {
            return await _context.Clients.Include(c => c.Purchases).ToListAsync();
        }

        public async Task AddPurchaseAsync(Purchase purchase)
        {
            var client = await _context.Clients.FindAsync(purchase.ClientId);
            if (client != null)
            {
                client.Points += purchase.CoffeesBought / 10;
                _context.Purchases.Add(purchase);
                await _context.SaveChangesAsync();
            }
        }
    }

}
