using Catalog.Domain.Common;
using System;
using System.Collections.Generic;

namespace Catalog.Domain.Entities
{
    public class Brand: BaseEntity
    {
        public Brand()
        {
            Products = new HashSet<Product>();
        }

        public int BrandId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
