using System;

namespace Catalog.Domain.Common
{
    public abstract class BaseEntity
    {
       public string CreatedBy { get; set; }
       public DateTime CreatedAt { get; set; }
       public string LastModifiedBy { get; set; }
       public DateTime LastModifiedAt { get; set; }
        public bool? IsEnable { get; set; } = true;
    }
}
