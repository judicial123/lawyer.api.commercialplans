using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Delete;

public class DeleteLegalTechPlanCommand : IRequest<Unit>
{
    public Guid Id { get; set; }
}
