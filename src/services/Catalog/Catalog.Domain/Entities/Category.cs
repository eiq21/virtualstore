using Catalog.Domain.Common;
using System;
using System.Collections.Generic;

namespace Catalog.Domain.Entities
{
    public class Category: BaseEntity
    {
        public Category()
        {
            Products  = new HashSet<Product>();
        }
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
