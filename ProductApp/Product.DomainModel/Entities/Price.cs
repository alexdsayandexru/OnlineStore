namespace ProductApp.Product.DomainModel
{
	public class Price : ValueObject
	{
		public decimal Value { get; internal set; }
		public Currency Currency { get; internal set; }
	}
}
