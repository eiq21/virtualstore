using AutoMapper;
using Catalog.Application.Contracts.Persistence;
using Catalog.Domain.Entities;
using MediatR;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Brands
{
    public class GetBrandsListQueryHandler : IRequestHandler<GetBrandsListQuery, List<BrandListViewModel>>
    {
        private readonly IAsyncRepository<Brand> brandRepository;
        private readonly IMapper mapper;
        public GetBrandsListQueryHandler(IMapper mapper, IAsyncRepository<Brand> brandRepository)
        {
            this.mapper = mapper;
            this.brandRepository = brandRepository;
        }
        public async Task<List<BrandListViewModel>> Handle(GetBrandsListQuery request, CancellationToken cancellationToken)
        {
            var allBrands = (await brandRepository.ListAllAsync()).OrderBy(e => e.Name);
            return mapper.Map<List<BrandListViewModel>>(allBrands);
        }
    }
}
