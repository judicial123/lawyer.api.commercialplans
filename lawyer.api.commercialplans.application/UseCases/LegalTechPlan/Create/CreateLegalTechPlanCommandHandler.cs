using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.LegalTechPlan;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Create;

public class CreateLegalTechPlanCommandHandler : IRequestHandler<CreateLegalTechPlanCommand, Guid>
{
    private readonly ILegalTechPlanCommandRepository _command;
    private readonly IMapper _mapper;

    public CreateLegalTechPlanCommandHandler(
        ILegalTechPlanCommandRepository command,
        IMapper mapper)
    {
        _command = command;
        _mapper = mapper;
    }

    public async Task<Guid> Handle(CreateLegalTechPlanCommand request, CancellationToken cancellationToken)
    {
        var entity = _mapper.Map<domain.LegalTechPlan>(request);
        await _command.CreateAsync(entity);
        return entity.Id;
    }
}
