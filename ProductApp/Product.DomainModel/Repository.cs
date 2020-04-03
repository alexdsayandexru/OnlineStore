using System;
using System.Collections.Generic;
using System.Text;
using ProductApp.Product.DomainModel.Services;

namespace ProductApp.Product.DomainModel
{
	public class Repository
	{		
		private IProductService _productService;
		public Repository(IProductService productService) => _productService = productService;
		public ICategoryService Category => _productService;
		public Services.IProductService Product => _productService;
		public IProductQuantityService ProductQuantity => _productService;
		public IProductPriceService ProductPrice => _productService;
	}
}
