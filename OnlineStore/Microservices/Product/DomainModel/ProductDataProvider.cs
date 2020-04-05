using System;
using System.Collections.Generic;
using OnlineStore.Microservices.Product.DomainModel.Entities;
using OnlineStore.Microservices.Product.DomainModel.Services;

namespace OnlineStore.Microservices.Product.DomainModel
{
    public class ProductDataProvider : IProductDataProvider
    {
        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Entities.Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductPrice entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductQuantity entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetAlls()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Entities.Product> GetAllsByCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(Category entity)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(Entities.Product entity)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(ProductPrice entity)
        {
            throw new NotImplementedException();
        }

        public void InsertOrUpdate(ProductQuantity entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Entities.Product> IPersistentService<Entities.Product>.GetAlls()
        {
            throw new NotImplementedException();
        }

        IEnumerable<ProductPrice> IPersistentService<ProductPrice>.GetAlls()
        {
            throw new NotImplementedException();
        }

        IEnumerable<ProductQuantity> IPersistentService<ProductQuantity>.GetAlls()
        {
            throw new NotImplementedException();
        }

        Entities.Product IPersistentService<Entities.Product>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        ProductPrice IPersistentService<ProductPrice>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        ProductQuantity IPersistentService<ProductQuantity>.GetById(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
