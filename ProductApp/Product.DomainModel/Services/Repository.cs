using System;
using System.Collections.Generic;
using System.Text;

namespace ProductApp.Product.DomainModel.Services
{
	public class Repository
	{
		private static Repository _repository;

		public static Repository Instance()
		{
			return _repository;
		}
	}
}
