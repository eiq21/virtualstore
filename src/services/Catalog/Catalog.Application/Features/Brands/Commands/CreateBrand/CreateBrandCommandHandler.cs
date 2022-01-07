using AutoMapper;
using Catalog.Application.Contracts.Persistence;
using Catalog.Domain.Entities;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Catalog.Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreateBrandCommandResponse>
    {
        private readonly IMapper mapper;
        private readonly IAsyncRepository<Brand> brandRepository;

        public CreateBrandCommandHandler(IMapper mapper, IAsyncRepository<Brand> brandRepository)
        {
            this.mapper = mapper;
            this.brandRepository = brandRepository;
        }
        public async Task<CreateBrandCommandResponse> Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            var createBrandCommandResponse = new CreateBrandCommandResponse();

            var validator = new CreateBrandCommandValidator();

            var validatorResult = await validator.ValidateAsync(request);

            if (validatorResult.Errors.Count > 0)
            {
                createBrandCommandResponse.Success = false;
                createBrandCommandResponse.ValidationErrors = validatorResult.Errors.Select(error => error.ErrorMessage).ToList();
            }

            var brand = new Brand() { Name = request.Name };
            brand = await brandRepository.AddAsync(brand);
            createBrandCommandResponse.Brand = mapper.Map<CreateBrandViewModel>(brand);

            return createBrandCommandResponse;
        }
    }
}
