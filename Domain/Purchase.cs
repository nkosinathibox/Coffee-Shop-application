namespace Coffee_Shop_application.Domain
{
    public class Purchase
    {
        public int? PurchaseId { get; set; }
        public int? ClientId { get; set; }
        public int? CoffeesBought { get; set; }
        public DateTime? PurchaseDate { get; set; }
        public Client Client { get; set; }
    }
}
