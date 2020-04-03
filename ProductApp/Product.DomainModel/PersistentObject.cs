using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Product.DomainModel
{
	public class PersistentObject
	{
		public Guid Id { get; internal set; }
		public string Name { get; set; }
		public string UpdateBy { get; internal set; }
		public DateTime UpdateDate { get; internal set; }
	}
}
