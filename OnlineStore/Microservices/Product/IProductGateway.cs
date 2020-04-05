using System.Collections.Generic;
using OnlineStore.Microservices.Product.Entities;

namespace OnlineStore.Microservices.Product
{
    public interface IProductGateway
    {
        IEnumerable<ProductDTO> GetProducts();
        void InsertOrUpdate(ProductDTO product);
    }
}
