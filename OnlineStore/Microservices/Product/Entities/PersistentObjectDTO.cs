using System;

namespace OnlineStore.Microservices.Product.Entities
{
    public class PersistentObjectDTO
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateDate { get; set; }

        public PersistentObjectDTO()
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
