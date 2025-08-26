using lawyer.api.commercialplans.application.DTO;
using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.LegalTechPlan.GetAll;

public class GetAllLegalTechPlanQuery : IRequest<List<LegalTechPlanDto>>, IRequest<LegalTechPlanDto>
{
}
