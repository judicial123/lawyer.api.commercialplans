using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.Delete;

public class DeleteMarketingPlanCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
