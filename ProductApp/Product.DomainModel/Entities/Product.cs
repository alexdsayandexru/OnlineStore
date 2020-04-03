namespace ProductApp.Product.DomainModel
{
	public class Product : PersistentObject
	{
		public Category Category { get; set; }
	}
}
