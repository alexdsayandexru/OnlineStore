using System;
using System.Collections.Generic;
using System.Text;
using ProductApp.Product.DomainModel.Services;

namespace ProductApp.Product.DomainModel
{
	public interface IProductService :
		ICategoryService, 
		Services.IProductService,
		IProductPriceService,
		IProductQuantityService
	{
	}
}
