using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.MarketingPlan;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.Create;

public class CreateMarketingPlanCommandHandler : IRequestHandler<CreateMarketingPlanCommand, Guid>
{
    private readonly IMarketingPlanCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateMarketingPlanCommandHandler(IMarketingPlanCommandRepository command, IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateMarketingPlanCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.MarketingPlan>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
