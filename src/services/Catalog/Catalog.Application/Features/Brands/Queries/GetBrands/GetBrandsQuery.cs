using MediatR;
using System.Collections.Generic;

namespace Catalog.Application.Features.Brands.Queries.GetBrands
{
    public class GetBrandsQuery: IRequest<List<BrandsViewModel>>
    {

    }
}
