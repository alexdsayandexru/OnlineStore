namespace OnlineStore.Microservices.Product.DomainModel.Entities
{
    public class Product : PersistentObject
    {
        public Category Category { get; set; }
    }
}
