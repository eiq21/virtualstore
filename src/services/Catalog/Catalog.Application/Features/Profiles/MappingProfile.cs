using AutoMapper;
using Catalog.Application.Features.Brands.Commands.CreateBrand;
using Catalog.Application.Features.Brands.Queries.GetBrands;
using Catalog.Domain.Entities;

namespace Catalog.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Brand, CreateBrandViewModel>();
            CreateMap<Brand, BrandsViewModel>();
        }
    }
}
