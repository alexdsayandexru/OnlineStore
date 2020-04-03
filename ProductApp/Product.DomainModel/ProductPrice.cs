using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Product.DomainModel
{
	public class ProductPrice : PersistentObject
	{
		public Product Product { get; internal set; }
		public Price Price { get; internal set; }
	}
}
