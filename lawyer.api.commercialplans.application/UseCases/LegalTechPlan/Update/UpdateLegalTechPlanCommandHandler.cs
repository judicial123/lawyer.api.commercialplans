using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.LegalTechPlan;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Update;

public class UpdateLegalTechPlanCommandHandler : IRequestHandler<UpdateLegalTechPlanCommand, Guid>
{
    private readonly ILegalTechPlanCommandRepository _command;
    private readonly ILegalTechPlanQueryRepository _query;

    public UpdateLegalTechPlanCommandHandler(
        ILegalTechPlanCommandRepository command,
        ILegalTechPlanQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Guid> Handle(UpdateLegalTechPlanCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        if (entity == null) throw new KeyNotFoundException($"The legal tech plan with ID {request.Id} does not exist.");

        entity.IdLawFirm = request.IdLawFirm;
        entity.StartDate = request.StartDate;
        entity.EndDate = request.EndDate;
        entity.Used = request.Used;
        entity.Price = request.Price;
        entity.DateModified = DateTime.UtcNow;

        await _command.UpdateAsync(entity);
        return entity.Id;
    }
}
