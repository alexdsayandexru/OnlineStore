using System;

namespace ProductApp.Product.DomainModel
{
	public class PersistentObject
	{
		public Guid Id { get; internal set; }
		public string Name { get; set; }
		public string UpdateBy { get; internal set; }
		public DateTime UpdateDate { get; internal set; }

		public override string ToString()
		{
			return Name;
		}
	}
}
