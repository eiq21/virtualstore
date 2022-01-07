using Catalog.Application.Responses;

namespace Catalog.Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommandResponse: BaseResponse
    {
        public CreateBrandCommandResponse(): base()
        {

        }

        public CreateBrandViewModel Brand { get; set; }
    }
}
