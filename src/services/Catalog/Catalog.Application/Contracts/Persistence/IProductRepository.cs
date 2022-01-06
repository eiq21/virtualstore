using Catalog.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Contracts.Persistence
{
    public interface IProductRepository : IAsyncRepository<Product>
    {

    }
}
