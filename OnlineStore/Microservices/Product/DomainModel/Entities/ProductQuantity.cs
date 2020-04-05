namespace OnlineStore.Microservices.Product.DomainModel.Entities
{
    public class ProductQuantity : PersistentObject
    {
        public Product Product { get; internal set; }
        public Quantity Quantity { get; internal set; }
    }
}
