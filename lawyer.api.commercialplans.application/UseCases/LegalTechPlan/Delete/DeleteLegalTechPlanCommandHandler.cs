using lawyer.api.commercialplans.application.Contracts.Interfaces.Persistence.LegalTechPlan;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Delete;

public class DeleteLegalTechPlanCommandHandler : IRequestHandler<DeleteLegalTechPlanCommand, Unit>
{
    private readonly ILegalTechPlanCommandRepository _command;
    private readonly ILegalTechPlanQueryRepository _query;

    public DeleteLegalTechPlanCommandHandler(ILegalTechPlanCommandRepository command, ILegalTechPlanQueryRepository query)
    {
        _command = command;
        _query = query;
    }

    public async Task<Unit> Handle(DeleteLegalTechPlanCommand request, CancellationToken cancellationToken)
    {
        var entity = await _query.GetByIdAsync(request.Id);
        await _command.DeleteAsync(entity);
        return Unit.Value;
    }
}
