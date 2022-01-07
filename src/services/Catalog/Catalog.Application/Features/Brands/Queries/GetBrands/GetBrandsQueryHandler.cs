using AutoMapper;
using Catalog.Application.Contracts.Persistence;
using Catalog.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Brands.Queries.GetBrands
{
    public class GetBrandsQueryHandler : IRequestHandler<GetBrandsQuery, List<BrandsViewModel>>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Brand> brandRepository;

        public GetBrandsQueryHandler(IMapper mapper,IAsyncRepository<Brand> brandRepository)
        {
            this.mapper = mapper;
            this.brandRepository = brandRepository;
        }
        public async Task<List<BrandsViewModel>> Handle(GetBrandsQuery request, CancellationToken cancellationToken)
        {
            var brands = (await brandRepository.ListAllAsync()).OrderBy(e => e.Name);
            return mapper.Map<List<BrandsViewModel>>(brands);
        }
    }
}
