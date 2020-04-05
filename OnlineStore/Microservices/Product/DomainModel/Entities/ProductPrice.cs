namespace OnlineStore.Microservices.Product.DomainModel.Entities
{
    public class ProductPrice : PersistentObject
    {
        public Product Product { get; internal set; }
        public Price Price { get; internal set; }
    }
}
