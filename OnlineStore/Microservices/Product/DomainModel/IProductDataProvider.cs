using OnlineStore.Microservices.Product.DomainModel.Services;

namespace OnlineStore.Microservices.Product.DomainModel
{
    public interface IProductDataProvider :
        ICategoryService,
        IProductService,
        IProductPriceService,
        IProductQuantityService
    {
    }
}
