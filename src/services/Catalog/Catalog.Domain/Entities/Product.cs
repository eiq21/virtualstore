using Catalog.Domain.Common;
using System;

namespace Catalog.Domain.Entities
{
    public class Product : BaseEntity
    {
        public int ProductId { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
    }
}
