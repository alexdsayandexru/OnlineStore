using System;

namespace OnlineStore.Microservices.Product.DomainModel.Entities
{
    public class PersistentObject
    {
        public Guid Id { get; internal set; }
        public string Name { get; set; }
        public string UpdateBy { get; internal set; }
        public DateTime UpdateDate { get; internal set; }

        public PersistentObject()
        {
            Id = Guid.NewGuid();
            UpdateDate = DateTime.Now;
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
