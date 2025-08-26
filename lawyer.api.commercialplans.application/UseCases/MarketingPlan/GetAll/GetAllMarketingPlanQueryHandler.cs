using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.MarketingPlan;
using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.GetAll;

public class GetAllMarketingPlanQueryHandler : IRequestHandler<GetAllMarketingPlanQuery, List<MarketingPlanDto>>
{
    private readonly IMarketingPlanQueryRepository _query;
    private readonly IMapper _mapper;

    public GetAllMarketingPlanQueryHandler(IMapper mapper, IMarketingPlanQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<List<MarketingPlanDto>> Handle(GetAllMarketingPlanQuery request, CancellationToken cancellationToken)
    {
        var entities = await _query.GetAllAsync();
        return _mapper.Map<List<MarketingPlanDto>>(entities);
    }
}
