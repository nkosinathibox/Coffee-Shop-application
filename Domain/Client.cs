namespace Coffee_Shop_application.Domain
{
    public class Client
    {
        public int? ClientId { get; set; }
        public string Name { get; set; }
        public int? Points { get; set; }
        public ICollection<Purchase>? Purchases { get; set; }
    }    
}
