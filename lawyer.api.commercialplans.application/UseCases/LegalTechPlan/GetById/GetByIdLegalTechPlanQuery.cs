using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.LegalTechPlan.GetById;

public class GetByIdLegalTechPlanQuery : IRequest<LegalTechPlanDto>
{
    public GetByIdLegalTechPlanQuery(Guid id)
    {
        Id = id;
    }

    public Guid Id { get; set; }
}
