using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.LegalTechPlan;
using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.LegalTechPlan.GetById;

public class GetByIdLegalTechPlanQueryHandler : IRequestHandler<GetByIdLegalTechPlanQuery, LegalTechPlanDto>
{
    private readonly IMapper _mapper;
    private readonly ILegalTechPlanQueryRepository _query;

    public GetByIdLegalTechPlanQueryHandler(
        IMapper mapper,
        ILegalTechPlanQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<LegalTechPlanDto> Handle(GetByIdLegalTechPlanQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        return _mapper.Map<LegalTechPlanDto>(entity);
    }
}
