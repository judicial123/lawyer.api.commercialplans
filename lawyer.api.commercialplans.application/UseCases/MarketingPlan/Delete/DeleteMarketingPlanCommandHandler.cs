using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.MarketingPlan;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.Delete;

public class DeleteMarketingPlanCommandHandler : IRequestHandler<DeleteMarketingPlanCommand, Unit>
{
    private readonly IMarketingPlanCommandRepository _command;
    private readonly IMarketingPlanQueryRepository _query;

    public DeleteMarketingPlanCommandHandler(IMarketingPlanCommandRepository command, IMarketingPlanQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Unit> Handle(DeleteMarketingPlanCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        await _command.DeleteAsync(entity);
        return Unit.Value;
    }
}
