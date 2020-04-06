using System.Collections.Generic;
using System.Linq;
using Ninject;
using Ninject.Modules;
using OnlineStore.Infrastructure.EventBus;
using OnlineStore.Microservices.Product.DomainModel;
using OnlineStore.Microservices.Product.DomainModel.Entities;
using OnlineStore.Microservices.Product.Entities;

namespace OnlineStore.Microservices.Product
{
	public class ProductGateway : IProductGateway
	{
		private Repository _model;
		private IEventBus _bus;

		public ProductGateway()
		{
			IKernel ninjectKernel = new StandardKernel(new ProductDomainModelConfigModule());
			_model = ninjectKernel.Get<Repository>();
			_bus = ninjectKernel.Get<EventBus>();
		}

		public IEnumerable<ProductDTO> GetProducts()
		{
			return _model.Product.GetAlls().Select(t => new ProductDTO().Map(t)).ToArray();
		}

		public void InsertOrUpdate(ProductDTO product)
		{
			_model.Product.InsertOrUpdate(new DomainModel.Entities.Product().Map(product));
			_model.ProductPrice.InsertOrUpdate(new ProductPrice().Map(product));
			_model.ProductQuantity.InsertOrUpdate(new ProductQuantity().Map(product));

			_bus.Publish(new IntegrationEvent());
		}
	}

	class ProductDomainModelConfigModule : NinjectModule
	{
		public override void Load()
		{
			Bind<IProductDataProvider>().To<ProductDataProvider>();
			Bind<IEventBus>().To<EventBus>();
			Bind<Repository>().ToSelf();
		}
	}
}
