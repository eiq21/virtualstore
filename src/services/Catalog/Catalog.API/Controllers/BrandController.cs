using Catalog.Application.Features.Brands.Commands.CreateBrand;
using Catalog.Application.Features.Brands.Queries.GetBrands;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Catalog.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private readonly IMediator mediator;

        public BrandController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost(Name ="AddBrand")]
        public async Task<ActionResult<CreateBrandCommandResponse>> Create([FromBody] CreateBrandCommand createBrandCommand)
        {
            var response = await mediator.Send(createBrandCommand);
            return Ok(response);
        }
        [HttpGet("all",Name = "GetAllBrands")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<BrandsViewModel>>> GetBrands()
        {
            var brands = await mediator.Send(new GetBrandsQuery());
            return Ok(brands);
        }
    }
}
