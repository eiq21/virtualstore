using AutoMapper;
using Catalog.Application.Features.Brands;
using Catalog.Domain.Entities;

namespace Catalog.Application.Features.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Brand, BrandListViewModel>().ReverseMap();
        }
    }
}
