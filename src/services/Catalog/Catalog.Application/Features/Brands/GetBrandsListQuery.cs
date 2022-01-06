using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Catalog.Application.Features.Brands
{
    public class GetBrandsListQuery:IRequest<List<BrandListViewModel>>
    {

    }
}
