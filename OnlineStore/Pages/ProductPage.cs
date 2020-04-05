using System;
using System.Windows.Forms;
using Ninject;
using Ninject.Modules;
using OnlineStore.Microservices;
using OnlineStore.Microservices.Order;
using OnlineStore.Microservices.Product;
using OnlineStore.Microservices.Product.Entities;

namespace OnlineStore.Pages
{
    public partial class ProductPage : UserControl
    {
        private Gateway _gateway;        

        public ProductPage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            IKernel ninjectKernel = new StandardKernel(new GatewayConfigModule());
            _gateway = ninjectKernel.Get<Gateway>();            
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            var product = new ProductDTO
            {
                Name = "Test name",
                Category = new CategoryDTO { Name = "Test category" },
                Price = new PriceDTO { Currency = CurrencyDTO.RUB, Value = 10 },
                Quantity = new QuantityDTO { Measure = MeasureDTO.Piece, Value = 2 }
            };

            _gateway.Product.InsertOrUpdate(product);
        }
    }

    class GatewayConfigModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IProductGateway>().To<ProductGateway>();
            Bind<IOrderGateway>().To<OrderGateway>();
            Bind<Gateway>().ToSelf();
        }
    }
}
