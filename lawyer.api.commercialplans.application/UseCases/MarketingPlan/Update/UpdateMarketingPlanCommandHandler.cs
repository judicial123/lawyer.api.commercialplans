using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.MarketingPlan;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.MarketingPlan.Update;

public class UpdateMarketingPlanCommandHandler : IRequestHandler<UpdateMarketingPlanCommand, Guid>
{
    private readonly IMarketingPlanCommandRepository _command;
    private readonly IMarketingPlanQueryRepository _query;

    public UpdateMarketingPlanCommandHandler(
        IMarketingPlanCommandRepository command,
        IMarketingPlanQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Guid> Handle(UpdateMarketingPlanCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity == null) throw new KeyNotFoundException($"The marketing plan with ID {request.Id} does not exist.");

        entity.IdLawFirm = request.IdLawFirm;
        entity.EntryDate = request.EntryDate;
        entity.ContactsNumber = request.ContactsNumber;
        entity.ContactsUsed = request.ContactsUsed;
        entity.Price = request.Price;
        entity.DateModified = DateTime.UtcNow;

        await _command.UpdateAsync(entity);
        return entity.Id;
    }
}
