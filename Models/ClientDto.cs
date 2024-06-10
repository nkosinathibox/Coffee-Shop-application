namespace Coffee_Shop_application.Models
{
    public class ClientDto
    {
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public int? Points { get; set; }
        public List<PurchaseDto> Purchases { get; set; }
    }
}
