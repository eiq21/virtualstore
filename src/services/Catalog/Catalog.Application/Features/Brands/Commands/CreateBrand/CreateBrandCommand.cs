using MediatR;

namespace Catalog.Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommand: IRequest<CreateBrandCommandResponse>
    {
        public string Name { get; set; }
    }
}
