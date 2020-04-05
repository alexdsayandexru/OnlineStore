using System.Collections.Generic;
using OnlineStore.Microservices.Product.DomainModel.Entities;

namespace OnlineStore.Microservices.Product.DomainModel.Services
{
    public interface IProductService : IPersistentService<Entities.Product>
    {
        IEnumerable<Entities.Product> GetAllsByCategory(Category category);
    }
}
