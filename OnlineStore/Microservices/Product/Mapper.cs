using OnlineStore.Microservices.Product.DomainModel.Entities;
using OnlineStore.Microservices.Product.Entities;

namespace OnlineStore.Microservices.Product
{
    internal static class Mapper
    {
        public static ProductDTO Map(this ProductDTO t, DomainModel.Entities.Product s)
        {
            return t;
        }

        public static DomainModel.Entities.Product Map(this DomainModel.Entities.Product t, ProductDTO s)
        {
            ((PersistentObject)t).Map(s);
            t.Category = (Category)((PersistentObject)new Category()).Map(s);
            return t;
        }

        public static PersistentObject Map(this PersistentObject t, ProductDTO s)
        {
            t.Id = s.Id;
            t.Name = s.Name;
            t.UpdateBy = s.UpdateBy;
            t.UpdateDate = s.UpdateDate;
            return t;
        }

        public static ProductPrice Map(this ProductPrice t, ProductDTO s)
        {
            t.Product = new DomainModel.Entities.Product().Map(s);
            t.Price = new Price().Map(s.Price);
            return t;
        }

        public static Price Map(this Price t, PriceDTO s)
        {
            t.Value = s.Value;
            t.Currency = (Currency)s.Currency;
            return t;
        }

        public static ProductQuantity Map(this ProductQuantity t, ProductDTO s)
        {
            t.Product = new DomainModel.Entities.Product().Map(s);
            t.Quantity = new Quantity().Map(s.Quantity);
            return t;
        }

        public static Quantity Map(this Quantity t, QuantityDTO s)
        {
            t.Value = s.Value;
            t.Measure = (Measure)s.Measure;
            return t;
        }
    }
}
