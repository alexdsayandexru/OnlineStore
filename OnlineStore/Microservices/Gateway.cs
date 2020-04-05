using OnlineStore.Microservices.Order;
using OnlineStore.Microservices.Payment;
using OnlineStore.Microservices.Product;

namespace OnlineStore.Microservices
{
    public class Gateway
    {
        private IProductGateway _productGateway;
        private IOrderGateway _orderGateway;
        private IPaymentGateway _paymentGateway;

        public Gateway(IProductGateway productGateway,
            IOrderGateway orderGateway,
            IPaymentGateway paymentGateway)
        {
            _productGateway = productGateway;
            _orderGateway = orderGateway;
            _paymentGateway = paymentGateway;
        }

        public IProductGateway Product => _productGateway;
        public IOrderGateway Order => _orderGateway;
        public IPaymentGateway Payment => _paymentGateway;
    }
}
