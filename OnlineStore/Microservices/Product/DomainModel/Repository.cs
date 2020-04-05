using OnlineStore.Microservices.Product.DomainModel.Services;

namespace OnlineStore.Microservices.Product.DomainModel
{
    public class Repository
    {
        private IProductDataProvider _productDataProvider;
        public Repository(IProductDataProvider productDataProvider) => _productDataProvider = productDataProvider;
        public ICategoryService Category => _productDataProvider;
        public IProductService Product => _productDataProvider;
        public IProductQuantityService ProductQuantity => _productDataProvider;
        public IProductPriceService ProductPrice => _productDataProvider;
    }
}
