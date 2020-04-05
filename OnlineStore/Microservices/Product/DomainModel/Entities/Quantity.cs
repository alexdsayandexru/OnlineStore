namespace OnlineStore.Microservices.Product.DomainModel.Entities
{
    public class Quantity : ValueObject
    {
        public decimal Value { get; set; }
        public Measure Measure { get; set; }
    }
}
