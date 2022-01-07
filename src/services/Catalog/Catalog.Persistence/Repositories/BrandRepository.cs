using Catalog.Application.Contracts.Persistence;
using Catalog.Domain.Entities;

namespace Catalog.Persistence.Repositories
{
    public class BrandRepository: BaseRepository<Brand>, IBrandRepository
    {
        public BrandRepository(CatalogDbContext context): base(context)
        {

        }
    }
}
