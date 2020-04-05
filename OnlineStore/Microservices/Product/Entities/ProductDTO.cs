namespace OnlineStore.Microservices.Product.Entities
{
    public class ProductDTO : PersistentObjectDTO
    {
        public CategoryDTO Category { get; set; }
        public PriceDTO Price { get; set; }
        public QuantityDTO Quantity { get; set; }
    }
}
