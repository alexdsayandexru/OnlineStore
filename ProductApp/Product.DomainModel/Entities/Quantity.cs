namespace ProductApp.Product.DomainModel
{
	public class Quantity : ValueObject
	{
		public decimal Value { get; internal set; }
		public Measure Measure { get; internal set; }
	}
}
