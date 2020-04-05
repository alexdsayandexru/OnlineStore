namespace OnlineStore.Microservices.Product.DomainModel.Entities
{
    public class Price : ValueObject
    {
        public decimal Value { get; set; }
        public Currency Currency { get; set; }
    }
}
