using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.LegalTechPlan;
using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.LegalTechPlan.GetAll;

public class GetAllLegalTechPlanQueryHandler : IRequestHandler<GetAllLegalTechPlanQuery, List<LegalTechPlanDto>>
{
    private readonly ILegalTechPlanQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllLegalTechPlanQueryHandler(
        IMapper mapper,
        ILegalTechPlanQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<LegalTechPlanDto>> Handle(GetAllLegalTechPlanQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<LegalTechPlanDto>>(entities);
        }
}
