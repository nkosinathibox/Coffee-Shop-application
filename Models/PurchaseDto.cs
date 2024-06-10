namespace Coffee_Shop_application.Models
{
    public class PurchaseDto
    {
        public int? PurchaseId { get; set; }
        public int? ClientId { get; set; }
        public int CoffeesBought { get; set; }
        public DateTime PurchaseDate { get; set; }
    }
}
