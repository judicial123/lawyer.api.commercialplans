using AutoMapper;
using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.MarketingPlan;
using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.GetById;

public class GetByIdMarketingPlanQueryHandler : IRequestHandler<GetByIdMarketingPlanQuery, MarketingPlanDto>
{
    private readonly IMapper _mapper;
    private readonly IMarketingPlanQueryRepository _query;

    public GetByIdMarketingPlanQueryHandler(IMapper mapper, IMarketingPlanQueryRepository query)
    {
        _mapper = mapper;
        _query = query;
    }

    public async Task<MarketingPlanDto> Handle(GetByIdMarketingPlanQuery request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        return _mapper.Map<MarketingPlanDto>(entity);
    }
}
