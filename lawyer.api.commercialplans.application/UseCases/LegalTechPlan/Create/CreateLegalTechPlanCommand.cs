using MediatR;

namespace lawyer.api.commercialplans.application.UseCases.LegalTechPlan.Create;

public class CreateLegalTechPlanCommand : IRequest<Guid>
{
    public Guid IdLawFirm { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public int Used { get; set; }
    public decimal Price { get; set; }
}
