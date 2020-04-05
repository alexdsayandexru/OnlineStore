using OnlineStore.Microservices.Order;
using OnlineStore.Microservices.Product;

namespace OnlineStore.Microservices
{
    public class Gateway
    {
        private IProductGateway _productGateway;
        private IOrderGateway _orderGateway;

        public Gateway(IProductGateway productGateway,
            IOrderGateway orderGateway)
        {
            _productGateway = productGateway;
            _orderGateway = orderGateway;
        }

        public IProductGateway Product => _productGateway;
        public IOrderGateway Order => _orderGateway;
    }
}
