using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.GetById;

public class GetByIdMarketingPlanQuery : IRequest<MarketingPlanDto>
{
    public GetByIdMarketingPlanQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
