using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.GetAll;

public class GetAllMarketingPlanQuery : IRequest<List<MarketingPlanDto>>, IRequest<MarketingPlanDto>
{
}
