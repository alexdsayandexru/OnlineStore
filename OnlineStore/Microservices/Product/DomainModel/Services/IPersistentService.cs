using System;
using System.Collections.Generic;
using OnlineStore.Microservices.Product.DomainModel.Entities;

namespace OnlineStore.Microservices.Product.DomainModel.Services
{
    public interface IPersistentService<T> where T : PersistentObject
    {
        T GetById(Guid id);
        IEnumerable<T> GetAlls();
        void InsertOrUpdate(T entity);
        void Delete(T entity);
    }
}
